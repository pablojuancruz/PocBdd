Funcionalidade: Conversão de Fahrenheit para outras escalas
	Ao informar uma temperatura em Fahrenheit
	Eu quero obter os valores equivalentes nas escalas Celsius e Kelvin

Cenário: Conversao 01
	Dado que a temperatura em Fahrenheit é de 32 graus
	Quando eu solicitar a conversão da temperatura
	Então a temperatura na escala Celsius será de 0 graus
	E a temperatura na escala Kelvin será de 273,15 graus

Cenário: Conversao 02
	Dado que a temperatura em Fahrenheit é de 86 graus
	Quando eu solicitar a conversão da temperatura
	Então a temperatura na escala Celsius será de 30 graus
	E a temperatura na escala Kelvin será de 303,15 graus

Cenário: Conversao 03
	Dado que a temperatura em Fahrenheit é de 90,5 graus
	Quando eu solicitar a conversão da temperatura
	Então a temperatura na escala Celsius será de 32,5 graus
	E a temperatura na escala Kelvin será de 305,65 graus

Cenário: Conversao 04
	Dado que a temperatura em Fahrenheit é de 212 graus
	Quando eu solicitar a conversão da temperatura
	Então a temperatura na escala Celsius será de 100 graus
	E a temperatura na escala Kelvin será de 373,15 graus
