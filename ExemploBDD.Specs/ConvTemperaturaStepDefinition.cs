using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ExemploBDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExemploBDD.Specs
{
    [Binding]
    public sealed class ConvTemperaturaStepDefinition
    {
        private double _temperaturaFahrenheit;
        private double _temperaturaCelsius;
        private double _temperaturaKelvin;

        [Given("que a temperatura em Fahrenheit é de (.*) graus")]
        public void CarregarTemperaturaFahrenheit(double temperatura)
        {
            _temperaturaFahrenheit = temperatura;


        }

        [When("eu solicitar a conversão da temperatura")]
        public void ProcessarConversaoTemperatura()
        {
            _temperaturaCelsius =
                ConversorTemperatura.FahrenheitParaCelsius(_temperaturaFahrenheit);
            _temperaturaKelvin =
                ConversorTemperatura.FahrenheitParaKelvin(_temperaturaFahrenheit);
        }

        [Then("a temperatura na escala Celsius será de (.*) graus")]
        public void ValidarTemperaturaCelsius(double valorEsperado)
        {
            Assert.AreEqual(valorEsperado, _temperaturaCelsius);
        }

        [Then("a temperatura na escala Kelvin será de (.*) graus")]
        public void ValidarTemperaturaKelvin(double valorEsperado)
        {
            Assert.AreEqual(valorEsperado, _temperaturaKelvin);
        }
    }
}