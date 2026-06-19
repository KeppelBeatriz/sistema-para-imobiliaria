## Instalação e Execução

O sistema é uma aplicação desktop desenvolvida em C# com Windows Forms, não requerendo instalação de servidor web. Para executá-lo localmente, siga os passos abaixo:

### Pré-requisitos

- Windows 10 ou superior
- MySQL Server instalado e rodando na porta 3306
- Usuário `root` com senha `1234`

### Banco de Dados

1. Acesse a pasta `src/db` do repositório
2. Abra o arquivo SQL no MySQL Workbench ou phpMyAdmin
3. Execute o script para criar o banco `imobiliaria` com todas as tabelas

### Executando o Sistema

1. Acesse a pasta `domos/bin/Debug` dentro do projeto
2. Execute o arquivo `domos.exe`
3. O sistema abrirá diretamente na tela de login
4. Use as credenciais cadastradas no banco para acessar como **RH** ou **Corretor**

---

## Histórico de Versões

### [1.0.0] - 19/06/2026

Adicionado

- Tela de login com acesso separado para RH e Corretor
- Módulo de cadastro e gerenciamento de Corretores (RH)
- Módulo de cadastro de RH/Administrador (RH)
- Cálculo de comissão por corretor (RH)
- Módulo de cadastro e gerenciamento de Clientes (Corretor)
- Módulo de cadastro e gerenciamento de Imóveis — Aluguel e Venda (Corretor)
- Módulo de agendamento e gerenciamento de Visitas (Corretor)
- Módulo de registro e gestão de Propostas (Corretor)
- Geração de relatório de propostas em arquivo `.txt`
- Banco de dados MySQL com 9 tabelas e relacionamentos via Foreign Keys
- Aplicação dos quatro pilares da POO: Abstração, Encapsulamento, Herança e Polimorfismo
