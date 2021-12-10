const host = "http://localhost:55476/api";
const endpoint = host + "/Solicitacao";

function Salvar(){
    let NotaFiscal = document.getElementById("nNotaFiscal").value;
    let Venda = document.getElementById("ordemVenda").value;
    let Frete = document.getElementById("cotacaoFrete").value;
    let PrazoInicial = document.getElementById("inicial").value;
    let PrazoFinal = document.getElementById("final").value;
    let Status = document.getElementById("status").value;
    let Request = new XMLHttpRequest();
    let solicitacao = 
    {
        "nota": NotaFiscal,
        "ordemVenda": Venda,
        "frete": Frete,
        "prazoInicio": PrazoInicial,
        "prazoFim": PrazoFinal,
        "status": Status
    };
    let teste = JSON.stringify(solicitacao);

    Request.open("POST" , endpoint);
    Request.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    Request.send(teste);
    LimpaCampos();
}

function carregarLista(){
    let request = new XMLHttpRequest();
    request.open("GET", endpoint);
    request.send();
    request.onload = function(){
        let solicitacao = JSON.parse(this.responseText);
        let tabela = document.getElementById("lista");
        let corpo = tabela.getElementsByTagName("tbody")[0];
        corpo.innerHTML = "";
        solicitacao.forEach(sol => {
            corpo.innerHTML += `<tr>
            <td>${sol.id}</td>
            <td>${sol.NotaFiscal}</td>
            <td>${sol.ordemVenda}</td>
            <td>${sol.Status}</td>
        </tr>`;
        })

    }
}


function LimpaCampos(){
    document.getElementById("nNotaFiscal").value = "";
    document.getElementById("ordemVenda").value = "";
    document.getElementById("cotacaoFrete").value = "";
    document.getElementById("inicial").value = "";
    document.getElementById("final").value = "";
    document.getElementById("status").value = "";
}