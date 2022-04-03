using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml;

namespace CurrencyExchangerDesktop
{
    public partial class CurrencyExchangerForm : Form
    {
        public CurrencyExchangerForm()
        {
            InitializeComponent();

            currencyComboBox.DataSource = new List<ComboItem>
            {
                new ComboItem{ Value = "USD", Text = "Доллар США"},
                new ComboItem{ Value="RUB", Text = "Российский рубль" },
                new ComboItem{ Value="EUR", Text = "Евро" }
            };

            currencyComboBox.DisplayMember = "Text";
            currencyComboBox.ValueMember = "Value";
        }

        private void HandleControlKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calculateButton.PerformClick();
        }

        private async void CalculateButton_Click(object sender, EventArgs e)
        {
            string selectedCurrency = currencyComboBox.SelectedValue.ToString();
            string selectedDate = datePicker.Value.Date.ToString("yyyyMMdd");

            HttpClient client = new HttpClient();

            calculateButton.Enabled = false;
            progressLabel.Visible = true;

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                HttpResponseMessage response = await client.GetAsync($"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date={selectedDate}&valcode={selectedCurrency}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.LoadXml(responseBody);

                XmlNodeList rateNodes  = xmlDoc.GetElementsByTagName("rate");

                if (rateNodes.Count == 0)
                {
                    MessageBox.Show("Курс валюты отсутствует на сервере", "Курс валюты не найден", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string rate = rateNodes[0].InnerText;
                    MessageBox.Show($"Курс валюты \"{currencyComboBox.SelectedValue}\" на дату {datePicker.Value.Date.ToString("dd.MM.yyyy")} равен: {rate}", $"Курс {selectedCurrency}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(HttpRequestException error)
            {
                MessageBox.Show(error.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Произошла неизвестная ошибка!", "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                calculateButton.Enabled = true;
                progressLabel.Visible = false;
            }
        }
    }
}
