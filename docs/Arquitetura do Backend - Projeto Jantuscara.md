**Arquitetura do Backend - Projeto Jantuscara**

O projeto Jantuscara adota uma estrutura baseada em **DDD (Domain-Driven Design)** e **Arquitetura Limpa (Clean Architecture)**, com uso de **Repository Pattern** e **Injeção de Dependência (DI)**.

A organização do backend segue a seguinte estrutura de diretórios e responsabilidades:

```
backend (Raiz do Projeto - Jantuscara)
├── Jantuscara (Camada de API)
│   ├── Controllers                → Camada de entrada (HTTP/API)
│   ├── Properties                 → Metadados do projeto
│   ├── Program.cs                → Configuração de injeção de dependências, pipeline HTTP, middlewares
│   ├── Dockerfile, appsettings*  → Infraestrutura de execução e configuração
│   └── Jantuscara.API.csproj     → Projeto da API
│
├── Jantuscara.Domain (Camada de Domínio)
│   ├── Entities                  → Entidades ricas do domínio
│   ├── Enums                     → Enumerações com regras fixas do domínio
│   ├── Interfaces                → Contratos para repositórios e serviços de domínio
│   └── Jantuscara.Domain.csproj  → Projeto do domínio
│
├── Jantuscara.Application (Camada de Aplicação)
│   ├── Interfaces                → Interfaces de casos de uso e serviços
│   ├── Services                  → Implementações específicas dos serviços de aplicação
│   ├── UseCases                 → Implementações dos casos de uso (application services)
│   └── Jantuscara.Application.csproj → Projeto da aplicação
│
├── Jantuscara.Infrastructure (Camada de Infraestrutura)
│   ├── Authentication            → Implementações específicas de autenticação/autorização
│   ├── Migrations                → Migrações de banco de dados
│   ├── Persistence               → Implementações de repositórios e acesso a dados (EF Core, por exemplo)
│   └── Jantuscara.Infrastructure.csproj → Projeto de infraestrutura
```

### Tecnologias:

* **.NET 8**
* **Entity Framework Core** para persistência
* **MySQL como banco de dados**
* **Injeção de dependência** via `Microsoft.Extensions.DependencyInjection`

### Padrões adotados:

* Casos de uso explícitos e independentes.
* Entidades ricas (comportamento dentro do domínio).
* Camadas desacopladas via interfaces.
* Mínima dependência da infraestrutura nas camadas superiores.
* Organização por responsabilidade e separação clara de contextos.

Este modelo permite:

* Testes unitários eficazes nas camadas de domínio e aplicação.
* Substituição facilitada de tecnologias (banco de dados, autenticação etc.).
* Escalabilidade e manutenção a longo prazo do sistema Jantuscara.

Todos os projetos seguem o padrão de nomes `Jantuscara.[Camada]`, e os namespaces devem seguir o mesmo formato.