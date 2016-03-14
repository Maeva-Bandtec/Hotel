$(document).ready(function () {

    $.get(window.location.href + 'api/data/get_db', function (dados) {
        $.each(dados.Agencias, function (index, obj) {
            $("#ddlAgencia").append("<option value=\"" + obj.Nome + "\">" + obj.Nome + "</option>");
        });

        var anos = new Array(),
            trimestre = new Array(),
            profissoes = new Array();

        $.each(dados.Clientes, function (index, obj) {
            if (anos.indexOf(obj.Profissao) < 0) {
                anos.push(obj.Profissao);
                $("#ddlClientes").append("<option value=\"" + obj.Profissao + "\">" + obj.Profissao + "</option>");
            }
        });

        $.each(dados.Tempos, function (index, obj) {
            if (anos.indexOf(obj.Ano) < 0) {
                anos.push(obj.Ano);
                $("#ddlAno").append("<option value=\"" + obj.Ano + "\">" + obj.Ano + "</option>");
            }

            if (trimestre.indexOf(obj.Trimestre) < 0) {
                trimestre.push(obj.Trimestre);
                $("#ddlTrimestres").append("<option value=\"" + obj.Trimestre + "\">" + obj.Trimestre + "</option>");
            }
        });
    })

    $("#btnAtt").click(function () {
        Filtra();
    });

    $("#btnAtt2").click(function () {
        Filtra2();
    });

    Filtra();
    Filtra2();
});

function CreateModel() {
    var model = {
        ano: $("#ddlAno").val(),
        nomeAgencia: $("#ddlAgencia").val()
    }
    return model;
};

function Filtra() {
    var model = CreateModel();

    $.ajax({
        url: window.location.href + "Home/GetFaturamentoAgenciaTempo",
        type: "POST",
        data: model,
        success: function (dados) {

            var arrayNomes = new Array()
            arrayAnos = new Array(),
            arrayValores = new Array();

            $.each(dados.result, function (index, objeto) {
                arrayNomes.push(objeto.NomeAgencia);
                arrayValores.push(objeto.ValorFaturado);

                if (arrayAnos.indexOf(objeto.AnoTempo) < 0) {
                    arrayAnos.push(objeto.AnoTempo);
                }
            });

            if (arrayAnos[0] == "0")
                arrayAnos[0] = "Todos";

            criaHigh(arrayNomes, arrayAnos, arrayValores);
        },
        error: function () {
            alert("Erro");
        }
    });
};

function criaHigh(nomes, anos, valores) {
    $(function () {
        $('#container').highcharts({
            chart: {
                type: 'bar'
            },
            title: {
                text: 'Fato Hospedagem'
            },
            subtitle: {
                text: 'Faturamento de Agência x Ano'
            },
            xAxis: {
                categories: nomes,
                title: {
                    text: null
                }
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Faturamento (reais)',
                    align: 'high'
                },
                labels: {
                    overflow: 'justify'
                }
            },
            tooltip: {
                valueSuffix: ' reais'
            },
            plotOptions: {
                bar: {
                    dataLabels: {
                        enabled: true
                    }
                }
            },
            legend: {
                layout: 'vertical',
                align: 'right',
                verticalAlign: 'top',
                x: -40,
                y: 100,
                floating: true,
                borderWidth: 1,
                backgroundColor: ((Highcharts.theme && Highcharts.theme.legendBackgroundColor) || '#FFFFFF'),
                shadow: true
            },
            credits: {
                enabled: false
            },
            series: [{
                name: anos,
                data: valores,
                color: "#FF7373"
            }]
        });
    });
};