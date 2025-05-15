# JantuscaraBackend

Projeto de backend desenvolvido em **.NET 8 Web API** utilizando **Arquitetura Limpa (Clean Architecture)** e princípios de separação de responsabilidades.

## 📦 Clonando o repositório

```bash
git clone https://github.com/mrffilipe/JantuscaraBackend.git
cd JantuscaraBackend
```

## ⚙️ Configuração inicial

Antes de executar o projeto, é necessário configurar as variáveis de ambiente **ou** editar o arquivo `appsettings.json`, localizado no projeto `Jantuscara.API`.

Exemplo de estrutura de configuração:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;Database=mydatabase;User=myuser;Password=mypassword123"
  }
}
```

> **Atenção:**
>
> * O projeto pode iniciar sem as configurações de `ConnectionStrings`, **porém**, **requisições que dependem do banco de dados** não funcionarão corretamente.
> * Certifique-se de que o **banco de dados** esteja configurado e em execução localmente.

Toda a documentação sobre configuração do banco de dados e detalhes técnicos da aplicação estão disponíveis no diretório `/docs`.

---

## ⚒️ Pré-requisitos para desenvolvimento

1. **.NET SDK 8.0**

   * Baixe e instale o SDK mais recente do .NET 8:
     👉 [https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

2. **EF Core CLI**

   * Para utilizar o Entity Framework CLI, instale a ferramenta globalmente:

     ```bash
     dotnet tool install --global dotnet-ef
     ```

> Após isso, certifique-se de que o caminho global do `.NET Tools` está incluído nas variáveis de ambiente do sistema, caso necessário.

---

## 🧱 Executando as migrations

Após configurar sua `ConnectionString`, execute os comandos a seguir para aplicar as migrations ao banco:

```bash
dotnet ef database update --project Jantuscara.Infrastructure --startup-project Jantuscara.API
```

---

## 🚀 Executando o projeto

Utilize a CLI do .NET para rodar o projeto:

```bash
dotnet restore
dotnet build
dotnet run --project Jantuscara.API
```

* O projeto principal (`startup`) é o **Jantuscara.API**.
* O Swagger estará disponível em: [http://localhost:5000/swagger](http://localhost:5000/swagger) (ou conforme configurado).

---

## 🏗️ Estrutura do Projeto

* `Jantuscara.API` — Camada de apresentação (Web API).
* `Jantuscara.Application` — Camada de aplicação (Casos de Uso, Interfaces de Serviços).
* `Jantuscara.Domain` — Camada de domínio (Entidades, Value Objects, Interfaces de Repositórios).
* `Jantuscara.Infrastructure` — Camada de infraestrutura (Persistência de dados, comunicação com serviços externos).
* `docs` — Documentação técnica do projeto.

---

## 📄 Documentação adicional

Consulte a pasta `/docs` para:

* Manual de configuração do banco de dados
* Descrição da arquitetura da aplicação
* Outros documentos técnicos relevantes

---

## 📚 Tecnologias utilizadas

* .NET 8 Web API
* MySQL
* Entity Framework Core
* Clean Architecture
* DDD (Domain-Driven Design)

---

# ✅ Conclusão

Este projeto foi estruturado para seguir boas práticas de arquitetura de software, priorizando **manutenibilidade**, **testabilidade** e **escalabilidade**.