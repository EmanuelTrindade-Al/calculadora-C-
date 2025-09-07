Calculadora Simples em C#

Uma calculadora gráfica desenvolvida em C# usando Windows Forms, com operações básicas (+, -, *, /) e interface amigável.

Funcionalidades

Adição, subtração, multiplicação e divisão.

Limpar (C) e cálculo do resultado (=).

Interface gráfica responsiva com botões e display.

Menu de atalhos via teclado (opcional).

Tecnologias

Linguagem: C# 10+

Framework: .NET 6 (Windows Forms)

Editor recomendado: Visual Studio Code

Instalação

Clone o repositório:

git clone https://github.com/seu-usuario/calculadora.git
cd calculadora


Compile e rode:

dotnet run


Para criar um executável:

dotnet publish -c Release -r win10-x64 --self-contained false


O .exe ficará em bin/Release/net6.0-windows/win10-x64/publish/.

Como usar

Clique nos números e nas operações para realizar cálculos.

Use C para limpar o display.

Clique = para mostrar o resultado.

Opcional: crie um atalho do .exe na área de trabalho para abrir rapidamente.

Estrutura do Projeto
Calculadora/
├─ bin/
├─ obj/
├─ Form1.cs
├─ Program.cs
├─ Calculadora.csproj
└─ README.md

Screenshots

Contribuições são bem-vindas. Abra um Pull Request ou issue para sugerir melhorias.

Licença

MIT License © Emanuel Trindade
