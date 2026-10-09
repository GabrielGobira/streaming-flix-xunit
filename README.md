# 🎬 StreamingFlix — Testes Unitários com xUnit

![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Linguagem-239120?logo=csharp&logoColor=white)
![xUnit](https://img.shields.io/badge/Testes-xUnit-blue)
![License](https://img.shields.io/badge/Licença-MIT-green)

## 📌 Sobre o projeto

O **StreamingFlix** é um projeto acadêmico desenvolvido em **C# com .NET 10**, voltado à prática de desenvolvimento de software, organização de projetos e implementação de testes unitários utilizando o framework **xUnit**.

O projeto tem como objetivo aplicar conceitos de programação e qualidade de software, demonstrando a importância dos testes automatizados na identificação de possíveis falhas e na validação do comportamento do código.

## 🎯 Objetivos

- Desenvolver habilidades práticas com C# e .NET.
- Compreender a estrutura de uma solução .NET.
- Aplicar conceitos de testes unitários utilizando xUnit.
- Organizar o código separando aplicação e testes.
- Utilizar Git e GitHub para versionamento.
- Praticar o desenvolvimento colaborativo.

## 🛠️ Tecnologias utilizadas

| Tecnologia | Finalidade |
|---|---|
| C# | Linguagem de programação |
| .NET 10 | Plataforma de desenvolvimento |
| xUnit | Framework de testes unitários |
| Git | Controle de versão |
| GitHub | Hospedagem e colaboração |
| Visual Studio / VS Code | Ambiente de desenvolvimento |

## 📂 Estrutura do projeto

```text
streaming-flix-xunit/
│
├── StreamingFlix.App/
│   └── Projeto principal da aplicação
│
├── StreamingFlix.Tests/
│   └── Projeto destinado aos testes unitários
│
├── StreamingFlix.slnx
├── .gitignore
├── LICENSE
└── README.md
```

A separação entre aplicação e testes facilita a organização, manutenção e evolução do projeto.

## 🚀 Como executar

### Pré-requisitos

- .NET SDK 10 instalado
- Git instalado
- Visual Studio, VS Code ou terminal compatível

### 1. Clonar o repositório

```bash
git clone https://github.com/GabrielGobira/streaming-flix-xunit.git
```

### 2. Acessar a pasta

```bash
cd streaming-flix-xunit
```

### 3. Restaurar as dependências

```bash
dotnet restore
```

### 4. Compilar a solução

```bash
dotnet build
```

### 5. Executar a aplicação

```bash
dotnet run --project StreamingFlix.App
```

## 🧪 Testes unitários

O projeto possui uma estrutura dedicada aos testes automatizados com **xUnit**.

Para executar os testes pelo terminal, utilize:

```bash
dotnet test
```

Os testes têm como finalidade verificar se os comportamentos implementados estão de acordo com os resultados esperados.

### Benefícios dos testes

- Identificação antecipada de erros.
- Maior confiabilidade do código.
- Facilidade de manutenção.
- Apoio à evolução do sistema.
- Redução de falhas após modificações.

## 🔄 Versionamento

O desenvolvimento utiliza **Git e GitHub**, permitindo o acompanhamento das alterações realizadas no código.

Entre as práticas utilizadas estão:

- Criação de commits.
- Organização de branches.
- Integração de alterações.
- Colaboração entre desenvolvedores.

## 📈 Possíveis melhorias futuras

- Ampliar a cobertura de testes.
- Implementar novos cenários de validação.
- Melhorar a documentação técnica.
- Adicionar integração contínua para execução automática dos testes.
- Evoluir as funcionalidades da aplicação.

## 👨‍💻 Autor

**Gabriel Gobira**, **Lorran Rodrigues**, **Gabriel Sena**


## 📄 Licença

Este projeto está disponibilizado sob a licença MIT. Consulte o arquivo `LICENSE` para mais informações.

---

⭐ Projeto desenvolvido para fins acadêmicos e aprimoramento de conhecimentos em C#, .NET e testes automatizados.
