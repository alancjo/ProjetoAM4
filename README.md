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

</hr>
<p>Primeiramente, estou disponibilizando este repositório para ajudar devs iniciantes que se deparam com problemas similares em um processo seletivo.
Podendo ser aplicado em qualquer linguagem de programação back-end. Qualquer dúvida fico a disposição para trocarmos conhecimento.</p>
<h2 style="color:gray; font-weight: 700">O que eu aprendi?</h2>

<p>Neste projeto pude aprender o funcionamento básico de uma linguagem fortemente tipada, orientada e objetos e compilada. Antes deste desafio, as linguagens na qual tive contato eram JavaScript, PHP e, principalmente, Python.</br>
O projeto é um CRUD(Create, Read, Update, Delete) para o envio das famosas mensagens de <strong>Fale Conosco</strong>. Foi criado uma área de admin para 
gerenciamento das mensagens com Identity Framework, já o relacionamento com o Banco de Dados e as Classes foi feita pelo ORM Entity Framework. As validações
dos campos foram todas feitas pela biblioteca <a href="https://developer.mozilla.org/pt-BR/docs/Web/HTML/Element/hr" target"_blank">JQuery do brasileiro Igor Escobar, menos a validação de CPF que foi feita no próprio back-end com C#. </br> O Front-end da aplicação foi feito com a framework CSS Bootstrap e disparo de alerta com o sweet alert com requisições Ajax</p>
<h4> Tecnologias utilizadas </h4>
<ul>
  <li>Linguagem <strong>C#</strong></li>
  <li>Linguagem <strong>JavaScript</strong></li>
  <li>Linguagem de marcação <strong>HTML</strong>
  <li>Plataforma <strong>.NET</strong></li>
  <li>Framework <strong>Asp. Net Core 3.1</strong></li>
  <li>Framework <strong>Bootstrap</strong></li>
  <li>Framework ORM <strong>Entity Framework</strong></li>  
  <li>Disparo de Alertas com <strong>Sweet Alert</strong></li>  
  <li>Área de admin com <strong>Identity Framework</strong></li>
  <li>Disparo email <strong>SMTP do google<strong></li>
</ul>

<h2>Obrigado por sua visita! :D</h2>

