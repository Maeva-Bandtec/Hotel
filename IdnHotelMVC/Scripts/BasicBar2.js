function CreateModel2() {
    var model = {
        profissao: $("#ddlClientes").val(),
        trimestre: $("#ddlTrimestres").val()
    }
    return model;
};

function Filtra2() {
    var model = CreateModel2();

    $.ajax({
        url: window.location.href + "Home/GetFaturamentoProfissaoTempo",
        type: "POST",
        data: model,
        success: function (dados) {

            var arrayNomes = new Array()
            arrayAnos = new Array(),
            arrayValores = new Array();

            $.each(dados.result, function (index, objeto) {
                arrayNomes.push(objeto.NomeProfissao);
                arrayValores.push(objeto.ValorFaturado);

                if (arrayAnos.indexOf(objeto.TrimestreTempo) < 0) {
                    arrayAnos.push(objeto.TrimestreTempo);
                }
            });

            if (arrayAnos[0] == "0")
                arrayAnos[0] = "Todos";

            criaHigh2(arrayNomes, arrayAnos, arrayValores);
        },
        error: function () {
            alert("Erro");
        }
    });
};

function criaHigh2(profissoes, trimestres, valores) {
    $(function () {
        $('#container2').highcharts({
            chart: {
                type: 'bar'
            },
            title: {
                text: 'Fato Consumo'
            },
            subtitle: {
                text: 'Faturamento de Profissão x Trimestre'
            },
            xAxis: {
                categories: profissoes,
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
                name: trimestres,
                data: valores,
                color: "#2AA198"
            }]
        });
    });
};