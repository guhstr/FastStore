# Sistema de Loja – MER e Projeto WebAPI (.NET)

Este repositório contém o material desenvolvido para o trabalho de CP1 de Banco de Dados e Programação WebAPI, cujo objetivo é elaborar um Modelo Entidade‑Relacionamento (MER) com no mínimo cinco entidades e iniciar uma solução WebAPI em .NET seguindo a Clean Architecture. O domínio escolhido foi o de uma **loja**.

## Membros do grupo

Gustavo Arthur Carvalho Sartori - RM561650

## Domínio escolhido

Optou‑se pelo domínio de uma **loja** de produtos. Nesse contexto, clientes efetuam pedidos contendo itens de produtos fornecidos por diferentes fornecedores. Os pagamentos podem ser realizados via diversos métodos (PIX, boleto, cartão, etc.).

## Entidades modeladas

A modelagem contempla as seguintes entidades principais:

Entidade e Descrição:
 **Categoria** - Representa uma categoria de produtos.
 **Fornecedor** - Representa o fornecedor de um produto.
 **Produto** - Representa um produto à venda na loja.
 **Cliente** - Representa um cliente que realiza pedidos.
 **Pedido** - Representa um pedido realizado por um cliente.
 **ItemPedido** - Representa o item de um pedido (produto e quantidade).            
 **Pagamento** - Representa o pagamento de um pedido.                              

### Relacionamentos e cardinalidades

Relacionamento e Cardinalidade / Opcionalidade
 **Categoria – Produto** - 1:N. Cada produto *deve* pertencer a uma categoria; uma categoria pode ter nenhum ou vários produtos.
 **Fornecedor – Produto** - 0..1:N. Um produto *pode* ter um fornecedor; um fornecedor pode ter nenhum ou vários produtos.
 **Cliente – Pedido** - 1:N. Um pedido *deve* estar associado a um cliente; um cliente pode ter nenhum ou vários pedidos.
 **Pedido – ItemPedido** - 1:N. Cada item de pedido *deve* pertencer a um pedido; um pedido pode ter nenhum ou vários itens.
 **Produto – ItemPedido** - 1:N. Cada item de pedido *deve* referenciar um produto; um produto pode aparecer em nenhum ou vários itens.
 **Pedido – Pagamento** - 0..1:1. Um pagamento *deve* estar associado a um pedido; um pedido pode não possuir pagamento (pendente) ou possuir exatamente um pagamento.

O relacionamento entre **Pedido** e **Produto** é de muitos‑para‑muitos e é implementado pela tabela associativa **ItemPedido**, que armazena atributos adicionais como quantidade e valor unitário.

## Diagrama MER

O diagrama de entidades‑relacionamentos apresenta as entidades, seus principais atributos (incluindo as chaves primárias, destacadas em negrito), e os relacionamentos com as cardinalidades e opcionalidades indicadas. Para montar o diagrama no draw.io, crie um retângulo para cada entidade listada, adicione os atributos (marcando a PK) e conecte as entidades com linhas anotadas conforme a tabela de relacionamentos.

## Estrutura do projeto

A solução foi estruturada segundo a Clean Architecture, utilizando a versão 9 do .NET.

Projeto e Tipo / Descrição
 **Projeto.Domain** - Biblioteca de classes que contém as entidades do domínio e enumerações.
 **Projeto.Application** - Camada de aplicação onde serão definidos casos de uso e interfaces (ainda vazia).
 **Projeto.Infrastructure** - Camada de infraestrutura destinada a implementações de acesso a dados (ainda vazia, sem EF Core ou migrations).
 **Projeto.Api** - Projeto WebAPI básico, sem controladores ou endpoints, responsável pela inicialização da aplicação.
