# KlenioLeite-ProjetoCaptani
Projeto .NET Core 3.1.8 - EF e CodeFirst (Migration)  - DDD utilizando API (HTTP Rest) com princípios de SOLID. 

## Para Executar o Projeto Devemos Seguir os Seguintes Passos:

- **1 -**  Executar as duas soluções existentes, sendo uma na pasta \KlenioLeite-ProjetoCaptani\SlnTesteCapitani, e \KlenioLeite-ProjetoCaptani\SlnTesteCapitani\SlnAPICapitani;
>Clique na imagem para ampliar
<img src="https://raw.githubusercontent.com/Migbari/RepositoriesImg/master/KlenioLeite-ProjetoCaptani/a_photo.png">

- **2 -** Execute a solução **(SlnAPICapitani)**, aguarde o carregamento e pegue o endereço gerado no browser (http://localhost:64829/).
>Esse é o endereço do IIS Express, mas ao disponibilizar a API em algum provedor de domínio o endereço ficará público

- **2.1 -** Antes de executar o outro projeto **(SlnCapitani)** entre no método RetornarDados() da classe ClienteController, altere a linha 27 do código para o endereço http de acesso a API e execute o Projeto WebAppCoreCapitani.
>Clique na imagem para ampliar
<img src="https://github.com/Migbari/RepositoriesImg/blob/master/KlenioLeite-ProjetoCaptani/b_photo.png?raw=true">


## Recursos Utilizados:

- **1 -** DDD - Domain Driven Design, arquitetura muito utilizada nas melhores empresas nos últimos tempos a qual proporciona desacoplamento total e organização real e de última geração em termos de melhores práticas e design patters que existe no mercado; dentro do modelo, para um melhor desempenho e agilidade de desenvolvimento, foram criadas estruturas genéricas tais como Interfaces e Classes Genéricas;
- **2 -** EF - Entity Framework, em termos de ORM, deixo aqui um texto obtido em meio a uma pesquisa, para uma definição mais acadêmica, no google:

O EF funciona com diversos tipos de banco de dados, e assim como todo e qualquer ORM, facilita o acesso ao banco de dados, mapeando suas tabelas e permitindo a manipulação dos registros sem muito esforço. ... O que diferencia o EF de outros ORM é o uso do LINQ para montagem de queries no próprio C#.

- **2.1 -** Quanto a performance, idem Google :) 

O Entity Framework é uma ferramenta ORM da Microsoft madura e testada pelo mercado que pode ser usada para aplicações que usam o .NET Framework, porém existem muitas maneiras de se obter maior performance com a ferramenta utilizando algumas dicas que vão fazer sua aplicação consumir menos recurso e/ou aumentar a performance.

Como estou utilizando sempre esse formato, que é a melhor forma de utilização da ferramenta e técnicas, é possível, e acontece, que hajam projetos mais antigos ou até novos que não se desejou ou se deseja utilizar o EF e/ou até linq, lambda, enfim (que são os dados já extraídos da base de dados, sendo manipulados em memória) que não usem o ORM, usem outros e até não utilizem, tendo talvez um SQLHelper próprio (podendo usar qualquer arquitetura que se desejo, como Facede, Factory, Singleton, enfim, com as quais já trabalhei); quanto a essa questão, sou flexível e tenho condições técnicas e de experiência para criação de ORM´s próprios e até com a utilização de refactoring.

>OBS: Existem artigos acadêmicos e profissionais que apresentam formas de tuning, para o EF; utilizar ou não será uma opção da empresa e o que for definido apenas sigo.

Para finalizar esse tópico: utilizei o recurso Code First **(Migration - Add-Migration, Update-Database)** para geração automática do banco, tabelas, e seus relacionamentos, de acordo com a estrutura que montei **(Estado Civil para Cliente, 1 para 1)**.

- **2.2 -** As regras de negócio fazem parte do Domínio de Negócio, sejam elas de Entidades (como é o caso de só existirem parceiros e data de nascimento do parceiro se o cliente for casado) e essas ficam dentro de cada entidade específica, e as de domínio, as quais seriam mais amplas e envolveriam várias classes e/ou recursos, tais como matemáticos e de negócio mais abrangentes; e porque essa estrutura foi proposta? por poder se tornar um ativo por meio de microserviços, estruturas **API REST**, para que todos os sistemas da empresa tenham acesso as mesmas e essas regras sejam centralizadas para melhor e mais rapidamente atender as demandas, não sendo necessária a "reinvenção da roda".

Foquei no Back-end, e a proposta foi fazer funcionar sem muitos "finais felizes" quanto a layouts de páginas e finalizações das mesmas, como também no sentido de ter que finalizar todas as camadas nos termos de um CRUD já que as classes e recursos de base e todo fluxo de processo já se apresentou executável e viável de se trabalhar.

Atenciosamente,
Klenio Leite.


