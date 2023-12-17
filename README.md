# DIO - Trilha .NET - Programação orientada a objetos

## Desafio de projeto
Este código em C# cria instâncias de dois tipos diferentes de smartphones: um Nokia e um iPhone. Ambos são subclasses da classe Smartphone.
O desafio tratou de herança, polimorfismo, classes e métodos abstratos.

## Contexto
Após completar o curso de Programação orientada a objetos com C#, o aluno é desafiado a modelar um sistema que trabalha com celulares, solicitado uma abstração de um celular e que seja disponibilizado maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
O dever é criar objetos de acordo com o diagrama abaixo, seguindo as regras do próximo tópico:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
Solucionado em 17 de dezembro de 2023 por @basiern no bootcamp Decola Tech em parceiria com a Avanade