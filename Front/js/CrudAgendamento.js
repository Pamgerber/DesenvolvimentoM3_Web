const host = "http://localhost:55476/api";
const endpoint = host + "/Agendamento";

function Salvar(){
    let IdSolicitacao= document.getElementById("IdSolicitacao").value;
    let NomeMotorista = document.getElementById("NomeMotorista").value;
    let placaVeiculo = document.getElementById("placaVeiculo").value;
    let capacidadeCarga = document.getElementById("capacidadeCarga").value;
    let diaColeta = document.getElementById("diaColeta").value;
    let Request = new XMLHttpRequest();
    let agendamento = 
    {
    "solicitacaoId": IdSolicitacao, 
    "motorista": NomeMotorista, 
    "placa": placaVeiculo, 
    "pesoMax": capacidadeCarga,
    "diaColeta": diaColeta
    };
    let teste = JSON.stringify(agendamento);

    Request.open("POST" , endpoint);
    Request.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    Request.send(teste);
    LimpaCampos();
}

function LimpaCampos(){
    document.getElementById("IdSolicitacao").value = "";
    document.getElementById("NomeMotorista").value= "";
    document.getElementById("placaVeiculo").value= "";
    document.getElementById("capacidadeCarga").value= "";
    document.getElementById("diaColeta").value= "";
}