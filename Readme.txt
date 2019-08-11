O projeto foi desenvolvido utilizando a linguagem C# e a IDE Visual Studio.

A ferramente de teste utilizado foi a extensão Restlet Cliente - Rest API Testing no Google Chrome.

As URLS da API devem seguem o padrão apaixo:


(GET) funcionarios/list
Exemplo: http://localhost:50301/api/funcionarios/list
Retorna todos os registro inseridos, não é necessário passar nenhum argumento.


(GET) funcionarios/show/id
Exemplo: http://localhost:50301/api/funcionarios/show?id=1 
Retorna o registro referente ao id especificado, é necessário passar o argumento "id".


(POST) funcionarios/create
Exemplo: http://localhost:50301/api/funcionarios/create?Nome=Aline&Cargo=Analista&Setor=Desenvolvimento&Endereco=Rua xxxx
Criar um novo registro de funcionário a partir do post, sendo necessário passar os argumentos "Nome", "Cargo", "Setor" e "Endereço".


(DELETE) funcionarios/destroy
Exemplo: http://localhost:50301/api/funcionarios/destroy?id=2
Excluí o registro referente ao id especificado no post, é necessário passar o argumento id.


(PUT) funcionarios/update
Exemplo: http://localhost:50301/api/funcionarios/update?id=2&Nome=Afonso&Cargo=Assistente&Setor=Comercial&Endereco=Avenida YYY
Atualiza o registro conforme os dados do post referente ao id, sendo necessário passar como argumento o "id" que se deseja alterar e os dados para alteração "Nome", "Cargo", "Setor" e "Endereço".


OBS: Todas as respostas da API estão no formato JSON.
