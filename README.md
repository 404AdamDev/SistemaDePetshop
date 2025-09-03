# 🐾 Sistema de Gestão de Animais de Estimação (PetShop)

![C#](https://img.shields.io/badge/C%23-9B4F96?style=for-the-badge\&logo=csharp\&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow?style=for-the-badge)
![Version](https://img.shields.io/badge/Versão-1.0-blue?style=for-the-badge)

---

## 📌 Sobre o projeto

Este projeto é um **sistema de gerenciamento de animais de um PetShop**, desenvolvido em **C#** para fins acadêmicos.
Ele permite **cadastrar, listar e gerenciar** animais utilizando os conceitos fundamentais de **Programação Orientada a Objetos (POO)**, como:

* **Classes e Objetos**
* **Encapsulamento**
* **Construtores**
* **Herança**
* **Polimorfismo**

---

## 🚀 Funcionalidades

* Adicionar diferentes tipos de animais (**Cachorro**, **Gato**, **Papagaio**)
* Listar os animais cadastrados, mostrando seus detalhes e sons característicos
* Calcular a **média de idade** dos animais cadastrados
* Menu interativo via console para fácil navegação

---

## 📂 Estrutura de Classes

### **Classe Base**

* `Animal`

  * Atributos: `NomeAN`, `IdadeAN`
  * Métodos:

    * `EmitirSom()` → método genérico, pode ser sobrescrito
    * `ExibirInfo()` → mostra as informações do animal

### **Classes Derivadas**

* `Cachorro` 🐶

  * Atributo adicional: `RacaAN`
  * `EmitirSom()` → exibe "Au Au"
  * `ExibirInfo()` → inclui a raça

* `Gato` 🐱

  * Atributo adicional: `CorAN`
  * `EmitirSom()` → exibe "Miau"
  * `ExibirInfo()` → inclui a cor

* `Papagaio` 🦜

  * `EmitirSom()` → exibe "Curupaco!"

### **Classe PetShop**

* Gerencia a **lista de animais** (`List<Animal>`)
* Métodos:

  * `AdicionarAnimal(Animal a)`
  * `ListarAnimais()`
  * `MediaIdade()`

---

## 🖥️ Como Executar

### **Pré-requisitos**

* [.NET SDK](https://dotnet.microsoft.com/download) 6.0 ou superior
* Editor recomendado: [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/)

---

### **Passo a passo**

```bash
# Clone este repositório
git clone https://github.com/seu-usuario/petshop-poo.git

# Acesse a pasta do projeto
cd petshop-poo

# Compile e execute
dotnet run
```

---

## 📸 Exemplo de Uso

```
~~~~~~~~~~~~ Pet Shop ~~~~~~~~~~~~
Bem vindo ao PetShop!
Neste sistema você pode gerenciar os animais da nossa loja física.
Então... Qual tipo de animal está pensando em cadastrar?
(se não estiver pensando em nenhum, pressione ENTER...)

>>> Adicionar Animal (adicionar)
>>> Dados PetShop (dados)
Sua escolha: adicionar

Animal 'Rex' adicionado com sucesso!
Animal 'Mimi' adicionado com sucesso!
Animal 'Loro' adicionado com sucesso!
```

---

## ✨ Conceitos Praticados

* **POO** com C#
* **Encapsulamento** com propriedades automáticas (`get; set;`)
* **Herança** para especialização de classes
* **Polimorfismo** através da sobrescrita (`override`) de métodos virtuais

---

## 🔧 Melhorias Futuras

* Persistência de dados em arquivo ou banco de dados
* Interface gráfica para facilitar o uso
* Sistema de busca e edição de animais cadastrados

---

## 📝 Licença

Este projeto foi desenvolvido para fins acadêmicos. Uso livre para estudos.
