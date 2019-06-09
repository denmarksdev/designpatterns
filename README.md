# Padrões de projeto 'Gang of Four' e outros em C#

# É necessário ...
- [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- [Visual studio 2017 ou 2019](https://visualstudio.microsoft.com/pt-br/) (Sugestão)
 
# Padrões de Projeto

## Criacional

### Factory Method

Define uma interface para a criação de um objeto, mas a sub classe decide qual classe será instanciada.

### Abstract Factory

Prove uma interface para criar uma família de objetos relacionados ou dependentes sem especificar sua classe concreta.

### Singleton Pattern

Tenha certeza que a classe terá apenas uma instância, e prover um ponto de acesso global a ela.

## Estrutual

### Decorator Pattern

Utiliza composição para limitar a herança e simplifica  o relacionamento entre os objetos, facilitando o seu gerenciamento.

## Comportamental

### Iterator Pattern

Prove um modo de acessar e iterar uma coleção de objetos de um mesmo modo, indenpendetement do tipo.

### Observer

Mudar um objeto causa a mudança ou ação em outro objeto atravéz da notificação.

## Outros

### Repository 

O uso do repositório permite aos desenvolvedores criarem uma camada de abstração entre a aplicação e camada de dados.

### Unity Of Work

A unidade de trabalho observa todas as ações durante uma transação de negócios, que pode afetar a base de dados.
Após concluída as alterações, a base de dados é resultado do seu trabalho.

# Referências

[Reynald Adolphe - **Design Patterns: Part 1**](https://www.linkedin.com/learning/c-sharp-design-patterns-part-1/next-steps)

