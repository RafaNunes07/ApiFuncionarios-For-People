O projeto foi desenvolvido utilizando a linguagem C# e a IDE Visual Studio.

As URLS da API devem seguem o padr�o apaixo:


(GET) funcionarios/list
Exemplo: http://localhost:50301/api/funcionarios/list
Retorna todos os registro inseridos, n�o � necess�rio passar nenhum argumento.


(GET) funcionarios/show/id
Exemplo: http://localhost:50301/api/funcionarios/show?id=1 
Retorna o registro referente ao id especificado, � necess�rio passar o argumento "id".


(POST) funcionarios/create
Exemplo: http://localhost:50301/api/funcionarios/create?Nome=Aline&Cargo=Analista&Setor=Desenvolvimento&Endereco=Rua xxxx
Criar um novo registro de funcion�rio a partir do post, sendo necess�rio passar os argumentos "Nome", "Cargo", "Setor" e "Endere�o".


(DELETE) funcionarios/destroy
Exemplo: http://localhost:50301/api/funcionarios/destroy?id=2
Exclu� o registro referente ao id especificado no post, � necess�rio passar o argumento id.


(PUT) funcionarios/update
Exemplo: http://localhost:50301/api/funcionarios/update?id=2&Nome=Afonso&Cargo=Assistente&Setor=Comercial&Endereco=Avenida YYY
Atualiza o registro conforme os dados do post referente ao id, sendo necess�rio passar como argumento o "id" que se deseja alterar e os dados para altera��o "Nome", "Cargo", "Setor" e "Endere�o".


OBS: Todas as respostas da API est�o no formato JSON.
