//charts
var myChart = echarts.init(document.getElementById('chart'));
let payRate = [30, 20, 15, 80, 70, 62, 30, 75];
var option = {
    tooltip: {
        trigger: 'item',
    },
    xAxis: {
        type: 'category',
        name: '棟',
        data: ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H']
    },

    yAxis: [{
        type: 'value',
        scale: true,
        name: '繳交比率(%)',
        max: 100,
        min: 0,
    }, ],

    series: [{
        data: payRate,
        type: 'bar',
        showBackground: true,
        backgroundStyle: {
            color: 'rgba(220, 220, 220, 0.8)'
        }

    }]
};

myChart.setOption(option);