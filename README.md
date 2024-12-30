<h1 align="center">
  <p align="center">Store System</p>
  <a href="#introdução"><img src="https://github.com/romulodeoliveira/romulodeoliveira/blob/main/img/csharp.png?raw=true" alt="Docusaurus"></a>
</h1>

# Introdução

No projeto que desenvolvi, priorizei o uso de boas práticas e padrões amplamente reconhecidos na engenharia de software, buscando criar um sistema robusto, escalável e bem testado. Aqui alguns conceitos aplicados durante o desenvolvimento:

## 1️⃣ Técnica de Escrita de Testes: Red, Green, Refactor

Adotei a abordagem TDD (Test-Driven Development), seguindo os passos Red, Green e Refactor. Inicialmente, escrevi testes que falhavam (Red) para cada funcionalidade. Em seguida, implementei o código mínimo necessário para que os testes passassem (Green). Por fim, refatorei o código, mantendo a funcionalidade intacta e garantindo maior clareza e eficiência.

## 2️⃣ Design by Contracts (DbC)

Implementei o princípio de Design by Contracts para definir contratos claros entre métodos e suas chamadas. Estabeleci pré-condições, pós-condições e invariantes que guiaram o comportamento do sistema, garantindo a consistência e prevenindo erros inesperados.

## 3️⃣ Conceitos de Orientação a Objetos (OOP)

A aplicação foi desenvolvida com base nos pilares da OOP: encapsulamento, herança, abstração e polimorfismo. Modelei o sistema de forma que as entidades do domínio refletissem a realidade do problema, com separação clara de responsabilidades e alto nível de reutilização de código.

## 4️⃣ Modelagem do Domínio da Aplicação

Realizei uma análise detalhada para modelar o domínio da aplicação, identificando entidades, valores e agregados principais. Essa modelagem foi crucial para garantir que o sistema atendesse aos requisitos do negócio de maneira precisa.

## 5️⃣ Criação e Teste de Validações de Entidades do Domínio

Implementei validações rigorosas para as entidades do domínio, assegurando integridade e consistência. Cada validação foi acompanhada de testes unitários para garantir sua eficácia em diferentes cenários.

## 6️⃣ Queries e Testes de Unidade - CQRS

Segui o padrão CQRS (Command Query Responsibility Segregation) para separar responsabilidades de leitura (queries) e escrita (commands). Criei queries otimizadas para buscar dados e implementei testes de unidade para validar seu funcionamento.

## 7️⃣ Commands e Testes de Unidade

Os commands foram implementados para representar ações específicas no sistema. Cada command foi extensivamente testado por meio de testes de unidade, garantindo que os dados fornecidos fossem processados corretamente.

## 8️⃣ Handlers e Testes de Unidade

Desenvolvi handlers para processar os commands e executar as regras de negócio correspondentes. Testes de unidade foram escritos para cada handler, assegurando a execução precisa das operações definidas.

## 9️⃣ Repository Pattern

Implementei o Repository Pattern para abstrair a lógica de acesso ao banco de dados, proporcionando uma camada clara e desacoplada para gerenciar a persistência dos dados.

## 🔟 Mockagem de Repositórios para Testes

Para garantir que os testes fossem independentes do banco de dados, criei repositórios mockados. Isso permitiu testar a lógica de negócio isoladamente, assegurando alta cobertura e confiança no sistema.

## ➡️ Resultados

O resultado foi um sistema bem estruturado, com alta manutenibilidade e confiabilidade. A adoção dessas práticas possibilitou a criação de um software robusto, onde as funcionalidades estão devidamente testadas e o comportamento esperado é garantido.

Este projeto foi um exercício valioso para aplicar teoria à prática e consolidar meu conhecimento em engenharia de software e boas práticas de desenvolvimento.

# Tecnologias utilizadas

- .NET 8
- Flunt
- MSTest

# Estatísticas

- Github issues: ![GitHub issues](https://img.shields.io/github/issues/romulodeoliveira/Store)
- Github forks: ![GitHub forks](https://img.shields.io/github/forks/romulodeoliveira/Store)
- Github stars: ![GitHub Repo stars](https://img.shields.io/github/stars/romulodeoliveira/Store)

# Desenvolvedores

| [<img src="https://avatars.githubusercontent.com/u/100490822?v=4" width=115><br><sub>Rômulo de Oliveira</sub>](https://github.com/romulodeoliveira) |
| :-------------------------------------------------------------------------------------------------------------------------------------------------: |
| .NET Developer |