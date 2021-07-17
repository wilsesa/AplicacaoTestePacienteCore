var datatable;

$(document).ready(function () {
    loadDataTable();
    var id = document.getElementById("pacienteId");
    if (id.value > 0) {
        $('#myModal').modal('show');
    }
});

function limpar() {
    var pacienteId = document.getElementById("pacienteId");
    var pacienteProntuario = document.getElementById("pacienteProntuario");
    var pacienteNome = document.getElementById("pacienteNome");
    var pacienteSobrenome = document.getElementById("pacienteSobrenome");
    var pacienteDataNascimento = document.getElementById("pacienteDataNascimento");
    var pacienteGenero = document.getElementById("pacienteGenero");
    var pacienteCPF = document.getElementById("pacienteCPF");
    var pacienteEmail = document.getElementById("pacienteEmail");
    var pacienteCelular = document.getElementById("pacienteCelular");
    var pacienteTelFixo = document.getElementById("pacienteTelFixo");
    var pacienteConvenio = document.getElementById("pacienteConvenio");
    var pacienteCarterinha = document.getElementById("pacienteCarterinha");
    var pacienteValidade = document.getElementById("pacienteValidade");
    var pacienteEstado = document.getElementById("pacienteEstado");

    pacienteId.value = 0;
    pacienteProntuario.value = 0;
    pacienteNome.value = "";
    pacienteSobrenome.value = "";
    pacienteDataNascimento.value = true;
    pacienteGenero.value = "";
    pacienteCPF.value = "";
    pacienteEmail.value = "";
    pacienteCelular.value = "";
    pacienteTelFixo.value = "";
    pacienteConvenio.value = "";
    pacienteCarterinha.value = "";
    pacienteValidade.value = true;
    pacienteEstado.value = true;
}

function loadDataTable() {
    datatable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Paciente/ObterTodos"
        },
        "columns": [
            { "data": "prontuario", "width": "10%" },
            { "data": "nome", "width": "10%" },
            { "data": "sobrenome", "width": "10%" },
            { "data": "dataNascimento", "width": "10%" },
            { "data": "genero", "width": "10%" },
            { "data": "cpf", "width": "10%" },
            { "data": "email", "width": "10%" },
            { "data": "celular", "width": "10%" },
            { "data": "telFixo", "width": "10%" },
            { "data": "convenio", "width": "10%" },
            { "data": "carterinha", "width": "10%" },
            { "data": "validade", "width": "10%" },
            {
                "data": "estado",
                "render": function (data) {
                    if (data == true) {
                        return "Ativo";
                    }
                    else {
                        return "Inativo";
                    }
                }, "width": "20%",
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div>
                            <a href="/Paciente/Criar/${data}" class="btn btn-success text-white" style="cursor:pointer;">
                            Edit
                            </a>
                        </div>
                           `;
                }, "width": "10%"
            }
        ]
    });
}