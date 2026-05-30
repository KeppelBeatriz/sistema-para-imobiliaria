# Apresentação

O sistema desenvolvido pelo grupo consiste em uma plataforma de gerenciamento para uma imobiliária, cujo objetivo é facilitar o controle de imóveis, clientes, corretores, visitas e propostas de aluguel ou venda.
O sistema permitirá que funcionários da imobiliária realizem o cadastro e gerenciamento de imóveis, clientes e corretores, além do acompanhamento de propostas comerciais e agendamento de visitas.


## Objetivos

O sistema atua como o núcleo de inteligência do negócio, integrando os dados cadastrais às operações de campo. O escopo do software abrange os seguintes macro-requisitos funcionais:

- Módulo de Cadastros Estruturados (CRUD): Subsistema responsável pelo gerenciamento do ciclo de vida (criação, leitura, atualização e exclusão) das entidades fundamentais do negócio, operando de forma distinta sobre imóveis de aluguel e venda, clientes e corretores.
- Mecanismo de Consultas e Filtros Dinâmicos: Motor de busca projetado para realizar varreduras no inventário de propriedades, permitindo o refinamento dos resultados por meio de parâmetros combinados de tipologia (tipo), faixas de teto financeiro (valor) e status de disponibilidade do imóvel.
- Orquestração de Agenda Comercial (Visitas): Camada voltada à gestão de relacionamento, encarregada de consolidar os agendamentos de visitas técnicas, correlacionando clientes, corretores e imóveis em cronogramas específicos, além de armazenar feedbacks qualitativos pós-atendimento.
- Subsistema de Transações e Triagem de Propostas: Módulo focado no controle de ofertas financeiras de compra e aluguel. Implementa regras de validação para impedir propostas duplicadas ou valores incoerentes, disparando um controle automatizado que atualiza o status de disponibilidade do imóvel no catálogo assim que uma negociação é deferida.
- Módulo de Performance Comercial: Funcionalidade voltada ao controle e cálculo automatizado da comissão dos corretores com base nas transações financeiras consolidadas por cada profissional.