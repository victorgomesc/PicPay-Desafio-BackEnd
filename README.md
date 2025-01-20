### PicPay Desafio Back-End

## Leia o texte abaixo

<h3>Objetivo: PicPay Simplificado</h3>

<p>O PicPay Simplificado é uma plataforma que permite pagamentos de forma simplificada. Nela, é possível realizar 
depósitos e transferências de dinheiro entre usuários. Existem dois tipos de usuários: comuns e lojistas. Ambos 
possuem uma carteira virtual para gerenciar seu saldo e realizar transferências.</p>

<h3>Requisitos</h3>

<p>Abaixo estão as regras de negócio importantes para o funcionamento do PicPay Simplificado:</p>
<ul>
<li>Cadastro único por CPF/CNPJ ou e-mail:<li>

<li>Ambos os tipos de usuários devem informar Nome Completo, CPF, e-mail e Senha.</li>
<li>CPF/CNPJ e e-mails devem ser únicos no sistema, ou seja, o sistema deve impedir múltiplos cadastros com o mesmo CPF ou endereço de e-mail.</li>
<li>Transferências:</li>

<li>Usuários podem transferir dinheiro para lojistas ou outros usuários.</li>
<li>Lojistas apenas recebem transferências e não podem enviar dinheiro para ninguém.</li>
<li>Validação de saldo:</li>

<li>O sistema deve garantir que o usuário tenha saldo suficiente antes de concluir uma transferência.</li>
<li>Autorização externa:</li>

<li>Antes de finalizar uma transferência, deve-se consultar um serviço externo de autorização.</li>
<li>Use o mock disponível neste link: https://util.devi.tools/api/v2/authorize</li>
<li>A consulta ao serviço deve ser feita utilizando o verbo GET.</li>
<li>Transações reversíveis:</li>

<li>Toda transferência deve ser uma transação segura. Em caso de inconsistência, a operação deve ser revertida, 
devolvendo o valor para a carteira do usuário remetente.
</li>
<li>Notificações:</li>

<li>Após receber o pagamento, o usuário ou lojista deve ser notificado.</li>
<li>A notificação pode ser enviada por e-mail, SMS ou outro serviço terceirizado. Caso o serviço de notificação esteja indisponível ou instável, deve-se usar o seguinte mock para simular a notificação: https://util.devi.tools/api/v1/notify. </li>
<li>A simulação deve ser feita utilizando o verbo POST.</li>
<li>Requisito técnico:</li>

<li>O sistema deve seguir o padrão RESTful.</li>

</ul>