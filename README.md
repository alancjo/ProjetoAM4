# Descrição do Projeto 

## 1 - Requisitos Obrigatórios
```
Asp.net core 3+
MVC (Model, View, Controller)
Sql Server (Caso não tenha, baixe o Sql Server Community)  
```

## 2 - Fale Conosco
<p>Desenvolver uma página web com um formulário de “Fale conosco”. O link da página deverá  ter: “/fale-conosco” Ex.: <Projeto>/ fale-conosco.  
  É necessário fazer um envio SMTP.</p>
  
<h4>Tal formulário precisa ter os seguintes campos:</h4>

```
DADOS PESSOAIS
→ Nome  
→ Data de Nascimento (com máscara de data padrão dd/mm/yyyy)  
→ CPF (com máscara e validação de CPF)  
→ E-mail (com validação)  
→ Celular (com máscara de tel.) 
```

```
ENDEREÇO
→ CEP  
→ Rua  
→ Numero  
→ Complemento  
→ Bairro  
→ Cidade (campo de texto, para facilitar)  
→ Estado (combobox/Select/Dropdown com os estados)  
```

```
MENSAGEM 
→ Título/Motivo da Mensagem  
→ Mensagem (textarea simples) 
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

## 5 - Diferenciais 
<p> Os diferenciais listados abaixo não são obrigatórios, entretantom contarão como pontos extras. </p>
<ul>
  <li>Criar uma área restrita para a listagem do Fale Conosco (só dando para acessar o link  mediante a login e senha);</li>
  <li>Usar o Identity para fazer o Login;</li>
  <li>Organização visual do Formulário e das tabelas;</li>
  <li>Nos fornecer o código via GIT Também (pode ser no GITHUB);</li>
  <li>Criar uma área de responder os e-mails (Disparando via SMTP);</li>
  <li>Criar uma área de responder os e-mails (Disparando via SMTP);
  <li>Realizar exclusão lógica.</li>
</ul>

### Dica:
<ul>
  <li>Use um Visual Studio mais recente para ajudar no Desenvolvimento; </li>
  <li>Utilize o SMTP do google para fazer os envios;</li>
  <li>Pode utilizar bibliotecas como o Bootstrap de estilo para auxiliar no Front End (Não  precisar ser nada bem elaborado).</li>
</ul>























