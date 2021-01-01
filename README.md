# Descrição do Projeto 

## 1 - Requisitos Obrigatórios
```
Asp.net core 3+
MVC (Model, View, Controller)
Sql Server (Caso não tenha, baixe o Sql Server Community)  
```
<hr>
### 2 - Fale Conosco
<p>Desenvolver uma página web com um formulário de “Fale conosco”. O link da página deverá  ter: “/fale-conosco” Ex.: <Projeto>/ fale-conosco.  
  É necessário fazer um envio SMTP.</p>
  
<h4>Tal formulário precisa ter os seguintes campos:</h4>
```
DADOS PESSOAIS
o Nome  
o Data de Nascimento (com máscara de data padrão dd/mm/yyyy)  
o CPF (com máscara e validação de CPF)  
o E-mail (com validação)  
o Celular (com máscara de tel.) 
```
```
ENDEREÇO
o CEP  
o Rua  
o Numero  
o Complemento  
o Bairro  
o Cidade (campo de texto, para facilitar)  
o Estado (combobox/Select/Dropdown com os estados)  
```
```
MENSAGEM 
o Título/Motivo da Mensagem  
o Mensagem (textarea simples) 
```

## 3 - Listagem do fale conosco
<p>Cria uma outra página com uma tabela, listando todas as submissões feitas no formulário de  Fale Conosco. O Link da página precisa ter “admin/fale-conosco” Ex.: <projeto>/admin/fale conosco</p>
 <h4>A tabela precisa ser da seguinte forma: </h4> 

<table>
  <thead>
    <tr> 
      <th>ID</th>
      <th>Nome</th>
      <th>Número</th>
      <th>E-mail</th>
      <th>Data do Envio</th>
      <th>Título/Motivo</th>
      <th>Ações</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>1</td>
      <td>Alan Oliveira</td>
      <td>42</td>
      <td>alancjobm@gmail.com</td>
      <td>01/01/2020</td>
      <td>Sugestão</td>
      <td>Ver | Excluir</td>      
    </tr>
    <tr>
      <td>2</td>
      <td>Anderson Oliveira</td>
      <td>42</td>
      <td>teste@gmail.com</td>
      <td>02/01/2020</td>
      <td>Reclamação</td>
      <td>Ver | Excluir</td>      
    </tr>    
  </tbody>
</table>
  


























