# 🃏 Super Trunfo Pokémon

![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow)
![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![C#](https://img.shields.io/badge/C%23-OOP-blueviolet)

> Uma recriação clássica do Super Trunfo no terminal, unindo a nostalgia de Pokémon com arquitetura robusta em C#.

---

## 🎯 Sobre o Projeto

Nascido como um desafio acadêmico para consolidar conhecimentos em **Programação Orientada a Objetos (POO)**, este projeto transforma a teoria em uma experiência jogável. O objetivo foi simular a mecânica clássica do Super Trunfo de forma interativa direto na linha de comando.

Para resolver o desafio de gerenciar múltiplos status e turnos, desenvolvi um sistema em **C# utilizando .NET**. A arquitetura foca na separação de responsabilidades, resultando em um jogo fluido, com múltiplas rodadas, sistema de pontuação justo e comparações dinâmicas de atributos entre as cartas.

---

## ⚡ Impacto e Destaques Técnicos

O projeto foi construído pensando não apenas em funcionar, mas em ser escalável e seguro:

*   **Arquitetura Limpa:** A organização do código através da **separação de responsabilidades** reduziu drasticamente a complexidade, permitindo adicionar novos Pokémon no futuro sem alterar o núcleo do jogo.
*   **Estabilidade de Execução:** Implementação de **validações de entrada (input)** rigorosas, evitando travamentos em tempo de execução causados por digitação incorreta do usuário.
*   **Controle de Estados:** Uso inteligente de **Enums** para mapear atributos (Ataque, Defesa, Velocidade), garantindo tipagem forte e evitando bugs lógicos.

---

## ⚙️ Funcionalidades

- 🃏 **Sorteio Dinâmico:** Distribuição aleatória e justa do baralho.
- 🎮 **Estratégia do Jogador:** Escolha de atributos a cada turno de ataque.
- ⚔️ **Motor de Combate:** Comparação automática de status das cartas.
- 🧮 **Placar em Tempo Real:** Sistema de pontuação cumulativa.
- 🔁 **Loop de Gameplay:** Suporte para múltiplas rodadas ininterruptas.

---

## 🚀 Tecnologias Utilizadas

- **C#** (Linguagem base)
- **.NET SDK** (Framework e ambiente de execução)
- **POO** (Paradigma de Programação Orientada a Objetos)

---

## 📦 Como Instalar e Jogar

### Pré-requisitos
Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

### Passo a Passo

1. Clone o repositório para a sua máquina local:
```bash
git clone [https://github.com/johnabyner/Supertrumfo-Pokemon.git](https://github.com/johnabyner/Supertrumfo-Pokemon.git)

Navegue até o diretório do projeto:

cd Supertrumfo-Pokemon

Execute o jogo diretamente pelo terminal:

dotnet run
