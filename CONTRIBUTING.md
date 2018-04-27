Contribuindo ao CSharpCoin Core
============================

O projeto CSharpCoin Core opera um modelo de colaboração aberto onde qualquer pessoa é
bem-vinda a contribuir para o desenvolvimento sob a forma de revisões por pares,
testes e patches. Este documento explica o processo prático e as diretrizes para
contribuir.

Em primeiro lugar, em termos de estrutura, não existe um conceito particular de 
"Core developers" no sentido de pessoas privilegiadas. Open Source muitas vezes, naturalmente
gira em torno da meritocracia, onde contribuintes de longo prazo ganham mais confiança de
a comunidade de desenvolvedores. Entretanto, alguma hierarquia é necessária para algumas
finalidades. Como tal, existem repositórios "mantenedores" no qual é responsável por
mesclar pull requests bem como um "mantenedor líder" no qual é responsável pelo
ciclo de release, mesclagem do todo, moderação e nomeação de mantenedores.


Fluxo de Trabalho do Colaborador
--------------------

A base de código é mantida usando o "fluxo de trabalho do colaborador", onde todos
sem exceção, contribui com propostas de correção utilizando "pull requests". Este
facilita a contribuição social, testes e revisão por pares.

Para contribuir com um patch, o fluxo de trabalho é o seguinte:

  1. Efetuar um Fork no repositório
  1. Criar um Branch de tópico
  1. Efetuar Commits de patches


A mensagem de um Commit deve ser detalhada por padrão, consistindo de uma linha de assunto curta
(50 caracteres no máximo), a blank line and detailed explanatory text as separate
paragraph(s), unless the title alone is self-explanatory (like "Corrected typo
in init.cpp") in which case a single title line is sufficient. A mensagem de um Commit deve ser
útil para as pessoas que leem o seu código no futuro, então explique o raciocínio de
suas decisões.

Se um commit específico fizer referência a outro problema, adicione a referência. Por
exemplo: `ref #1234` or `ajuste #4321`. Utilizando as palavras chave `ajuste` ou `conclusao`
fará com que o problema correspondente seja fechado quando a solicitação pull for mesclada.

Por favor, consulte o [Git manual](https://git-scm.com/doc) Para maiores informações
sobre o Git.

  - Faça o Push de mudanças ao seu fork
  - Crie um pull request

Se um pull request não for considerado para fazer um merge (ainda), por favor
prefixe o título com [WIP].

Nesta fase, deve-se esperar comentários e revisões de outros contribuintes. Você
pode adicionar mais commits ao seu pull request efetuando um commit localmente 
e efetuando um push ao seu fork até que você tenha satisfeito todo o feedback.


### Revisão por Pares

Qualquer pessoa pode participar de uma revisão por pares que seja expressa por comentários no 
pull request. Geralmente, os revisores revisarão o código em busca de erros óbvios, bem como
testar o conjunto de patches e opinar sobre os méritos técnicos do patch. Os mantenedores 
do projeto levam em consideração a revisão por pares ao determinar se há
consenso para efetuar o merge do pull request (lembre-se que as discussões podem ter sido
espalhados pelo GitHub).

Política de Release
--------------

O líder do projeto é o gerente de lançamento de cada release do CSharpCoin Core.

Copyright
---------

Ao contribuir para este repositório, você concorda em licenciar seu trabalho sob a
licença MIT. Qualquer trabalho contribuído onde você não é o autor original, 
deve conter o cabeçalho de licença com o autor original e a fonte.
