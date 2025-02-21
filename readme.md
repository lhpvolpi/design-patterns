# Design Patterns em C#

Este projeto contém implementações de diversos **Design Patterns** em C#, com exemplos práticos de como aplicá-los no desenvolvimento de software.

## 📌 **Design Patterns Implementados**

### 🔹 **Criacionais**

1. **Factory Method** - Criação de objetos de forma encapsulada.
2. **Singleton** - Garante uma única instância global da classe.

### 🔹 **Estruturais**

3. **Adapter** - Converte uma interface para outra esperada.
4. **Facade** - Simplifica a complexidade de um subsistema fornecendo uma interface única.

### 🔹 **Comportamentais**

5. **Strategy** - Permite a troca dinâmica de algoritmos em tempo de execução.
6. **Observer** - Notificação automática de mudanças de estado entre objetos.

---

## 🚀 **Como Rodar o Projeto**

### **1️⃣ Clonar o Repositório**

```bash
git clone https://github.com/lhpvolpi/design-patterns.git
cd design-patterns
```

### **2️⃣ Executar o Projeto no Visual Studio ou VS Code**

- Abra o projeto no **Visual Studio** ou **VS Code**.
- Certifique-se de que a versão do .NET Core instalada seja **6.0 ou superior**.
- Execute o comando:

```bash
dotnet run
```

---

## 🧪 **Testes Unitários**

O projeto possui testes automatizados usando **xUnit** para verificar o funcionamento correto dos padrões.

### **Rodando os Testes**

```bash
dotnet test
```

### **📌 Importante sobre testes paralelos**

Para evitar problemas com `Console.Out` em testes concorrentes, a paralelização foi desativada no **xUnit**.

- Para **desativar todos os testes paralelos**, veja `AssemblyInfo.cs`:
  ```csharp
  [assembly: CollectionBehavior(DisableTestParallelization = true)]
  ```

---

## 📂 **Estrutura do Projeto**

```
/design-patterns-csharp
│── /src
│   ├── Adapters
│   ├── Facades
│   ├── Factories
│   ├── Observers
│   ├── Singletons
│   ├── Strategies
│── /tests
│   ├── AdapterTests.cs
│   ├── FacadeTests.cs
│   ├── FactoryTests.cs
│   ├── ObserverTests.cs
│   ├── SingletonTests.cs
│   ├── StrategyTests.cs
│── README.md
│── .gitignore
│── DesignPatterns.csproj
```

---

## 📖 **Referências**

- [Refactoring Guru - Design Patterns](https://refactoring.guru/design-patterns)
- Livro: _Design Patterns: Elements of Reusable Object-Oriented Software_ (Gang of Four)
- Livro: _Clean Architecture_ - Robert C. Martin

🔥 **Contribuições são bem-vindas!** Faça um **fork** do repositório e envie um PR. 🚀
