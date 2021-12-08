const host = "http://localhost:55476/api";
const endpoint = host + "/Contato";

function Salvar(){
    let nome = document.getElementById("nomeContato").value;
    let email = document.getElementById("emailContato").value;
    let assunto = document.getElementById("emailAssunto").value;
    let mensagem = document.getElementById("exampleFormControlTextarea1").value;
    let Request = new XMLHttpRequest();
    let Contato = {"nome": nome, "email": email, "assunto": assunto, "mensagem": mensagem};
    let teste = JSON.stringify(Contato);

    Request.open("POST" , endpoint);
    Request.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    Request.send(teste);
    LimpaCampos();
}

function LimpaCampos(){
    document.getElementById("nomeContato").value = "";
    document.getElementById("emailContato").value = "";
    document.getElementById("emailAssunto").value = "";
    document.getElementById("exampleFormControlTextarea1").value = "";
}