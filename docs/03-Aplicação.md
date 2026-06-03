# Pilares da Orientação a Objetos no Sistema

### 1. Abstração
No sistema, serão utilizadas classes abstratas para representar estruturas genéricas do domínio do problema, impedindo a instanciação direta de objetos genéricos.

* **`Classe Usuario`**: Será abstrata porque não existe um "usuário genérico" no sistema. Ela servirá estritamente como base para as classes de operadores internos:
    * `Corretor`
    * `RH`
* **`Classe Imovel`**: Será abstrata, pois o sistema trabalhará exclusivamente com tipos específicos de imóveis:
    * `ImovelAluguel`
    * `ImovelVenda`

---

### 2. Encapsulamento
O encapsulamento será aplicado através de atributos privados/protegidos, resguardando os dados internos das classes. O acesso e a modificação desses estados serão realizados através de propriedades públicas `get` e `set` ou por métodos específicos de controle, garantindo a validação e a consistência das regras de negócio.

* **`Classe Usuario`**
    * **Atributos:** `Id`, `Nome`, `Cpf`, `Telefone`, `Email`, `Senha`.
    * **Controle de Acesso:** Propriedades públicas `get` e `set` com validações para impedir que campos obrigatórios (como `Nome` e `Cpf`) sejam armazenados em branco ou nulos.
* **`Classe Corretor`**
    * **Atributos:** `Creci`, `TaxaComissao`.
    * **Controle de Acesso:** O `set` da propriedade `TaxaComissao` validará o valor inserido para impedir que o percentual de comissão seja registrado com números negativos.
* **`Classe RH`**
    * **Atributos:** `NivelAcesso`.
    * **Controle de Acesso:** Restrição via propriedades públicas para garantir que o nível inserido corresponda estritamente aos valores numéricos de permissão aceitos pelo sistema.
* **`Classe Cliente`**
    * **Atributos:** `IdCliente`, `Nome`, `Cpf`, `DataNascimento`, `RendaMensal`, `Telefone`.
    * **Controle de Acesso:** Encapsula dados cadastrais e financeiros. O campo `RendaMensal` possuirá validação no `set` para barrar valores negativos, e `DataNascimento` controlará a consistência cronológica.
* **`Classe Imovel`**
    * **Atributos:** `Id`, `Tipo`, `Valor`, `Status`, `QtdQuartos`, `PossuiGaragem`.
    * **Controle de Acesso:** O atributo `Valor` será validado contra números negativos. O atributo `Status` terá seu acesso de escrita restrito para aceitar apenas os estados previstos pela regra de negócio (ex: *Disponível*, *Reservado*, *Vendido*).
* **`Classe ImovelAluguel`**
    * **Atributos:** `TaxaCondominio`, `IptuMensal`.
    * **Controle de Acesso:** Propriedades públicas com travas de validação lógica para garantir que taxas de condomínio e parcelas de IPTU não recebam valores menores que zero.
* **`Classe ImovelVenda`**
    * **Atributos:** `AceitaFinanciamento`, `ValorEscritura`.
    * **Controle de Acesso:** O atributo `ValorEscritura` será protegido contra valores negativos, e o booleano `AceitaFinanciamento` controlará as opções válidas para o módulo de propostas.
* **`Classe Endereco`**
    * **Atributos:** `Rua`, `Numero`, `Bairro`, `Cidade`, `Cep`.
    * **Controle de Acesso:** Impedirá que um imóvel seja cadastrado com o endereço em branco ou com informações incompletas, garantindo a integridade dos dados de localização.
* **`Classe Proposta`**
    * **Atributos:** `Id`, `DataProposta`, `Valor`, `CondicoesPagamento`, `Status`.
    * **Controle de Acesso:** O atributo `Valor` não aceitará números negativos. A modificação do atributo `Status` será realizada exclusivamente por métodos públicos específicos, impedindo alterações diretas e inválidas.
* **`Classe Visita`**
    * **Atributos:** `Id`, `DataHora`, `Status`.
    * **Controle de Acesso:** Gerenciamento do estado cronológico e situacional da agenda comercial. O campo `Status` será controlado estritamente por métodos como `Confirmar()` e `Cancelar()`.

---

### 3. Herança
A herança será aplicada para criar hierarquias onde classes mais específicas (filhas) aproveitam atributos e comportamentos de classes mais genéricas (pais), evitando a duplicação de código. No projeto, temos duas hierarquias estruturais principais:

#### Hierarquia de Operadores do Sistema
* **Superclasse (Abstrata):** `Usuario`
* **Subclasses:** `Corretor` e `RH`
* **Aplicação:** As classes filhas `Corretor` e `RH` herdam toda a base de identificação e autenticação (`Id`, `Nome`, `Cpf`, `Telefone`, `Email` e `Senha`) da superclasse. A partir dessa base herdada, cada subclasse expande seus próprios atributos específicos (ex: `Corretor` adiciona `Creci` e `TaxaComissao`; `RH` adiciona `NivelAcesso`).

#### Hierarquia de Imóveis
* **Superclasse (Abstrata):** `Imovel`
* **Subclasses:** `ImovelAluguel` e `ImovelVenda`
* **Aplicação:** Todo imóvel catalogado compartilha dados padronizados (`Id`, `Tipo`, `Valor`, `Status`, `QtdQuartos`, `PossuiGaragem` e sua associação de Composição com `Endereco`). As subclasses implementam os detalhes de sua modalidade comercial: `ImovelAluguel` adiciona `TaxaCondominio` e `IptuMensal`, enquanto `ImovelVenda` adiciona `AceitaFinanciamento` e `ValorEscritura`.

---

### 4. Polimorfismo
O polimorfismo permitirá que um mesmo comportamento seja tratado de formas diferentes dependendo do tipo de objeto instanciado, garantindo flexibilidade e facilitando o cálculo de valores sem a necessidade de condicionais (`if/else` ou `switch`) complexas.

* **Definição na Superclasse:** Na superclasse abstrata `Imovel`, foi definido o método genérico `CalcularValorTotal()`. A superclasse apenas dita a regra de que todo imóvel no sistema precisa saber calcular o seu valor final.
* **Reescrita nas Subclasses (`Override`):**
    * `ImovelAluguel`: O método `CalcularValorTotal()` é reescrito para somar ao valor base do aluguel as taxas específicas de `TaxaCondominio` e `IptuMensal`.
    * `ImovelVenda`: O método `CalcularValorTotal()` é reescrito para somar ao valor base do imóvel os custos operacionais da transação (`ValorEscritura`).

> 💡 **Aplicação Prática:** Quando a classe `GerenciadorImoveis` precisar listar os imóveis e exibir o preço final, ela chamará apenas o método `CalcularValorTotal()`. O próprio ecossistema da linguagem identificará em tempo de execução se deve aplicar a lógica de aluguel ou de venda, dependendo do objeto que estiver na memória.