# 📝 Entrevista Técnica Backend PicPay

Essa é uma prova técnica fornecida pela empresa PicPay para contratação de desenvolvedores desde o nível Júnior até o nível Senior. Essa distinção se dá dependendo do nível de implementações e tomadas de decisões utilizadas para realizacão da prova.

🔗 **Links:**
- Prova: https://github.com/PicPay/picpay-desafio-backend

## ⚙️ Requisitos Funcionais

- Manter usuários
- Realizar transferências
- Listar transferências por usuário
- Realizar consulta no serviço autorizador externo*
- Realizar notificação após transferências*

> <small> 🚧 _*Esses serviços externos fornecidos pela prova estão fora do ar. Levando isso em consideração, realizamos a implementação de somente um deles para nível didático e o deixamos comentado para não impedir nosso fluxo no sistema._</small>

## 📋 Requisitos Não Funcionais
- Usuários podem ser lojistas ou comuns
- Lojistas só recebem transferências, não enviam dinheiro para ninguém
- Usuários devem ter saldo suficiente para realizar transferências
- Antes de finalizar as transferências, deve-se consultar um serviço autorizador externo <small>(https://run.mocky.io/v3/8fafdd68-a090-496f-8c9a-3442cf30dae6)</small>
- As transferências devem estar em transações que serão revertidas em caso de qualquer inconsistência.
- Ao receber uma transferência, o usuário deverá receber uma notificação (envio de email, sms) enviada por um serviço de externo. <small>Este serviço pode estar indisponível/instável (http://o4d9z.mocklab.io/notify).</small>
- Serviço deve ser RESTFul

## 🎲 Requisitos de Dados
- User
    - Id  <small>`Guid`</small>
    - FirstName  <small>`string`</small>
    - LastName  `string`</small>
    - Email  <small>`string`</small>
    - Document  <small>`string`</small>
    - Wallet  <small>`decimal`</small>
    - Type  <small>`Enum`</small>
- Transaction
    - Id <small>`Guid`</small>
    - PayerId <small>`Guid`</small>
    - PayeeId <small>`Guid`</small>
    - Value <small>`decimal`</small>
    - Date <small>`DateTime`</small>

## 🧩 Pré-requisitos

- Docker
- .Net 7.0
- Microsoft.EntityFrameworkCore.Tools <small>(Global para rodar as migrations)</small>

## ⚒️ Instalação & Uso
1. Clone do projeto
```shell
   https://github.com/lucascidade/picpay-desafio.git
```
2. Navegue até a pasta clonada
```shell
    cd picpay
```
3. Crie a pasta Data
```shell
    mkdir Data
```
3. Execute as migrations
```shell
    dotnet ef database update
```
4. Execute o docker-compose
```shell
    docker-compose up
```
