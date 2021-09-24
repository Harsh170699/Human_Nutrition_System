let btn = document.getElementById('btn_bmi');

btn.addEventListener('click', function () {
    let weight = document.getElementById('weight-input').value;
    let height = document.getElementById('height-input').value;
    let finalbmi = (weight / (height * height) * 10000);
    document.getElementById('bmi-output').value = finalbmi;

    if (finalbmi <= 18.5) {
        document.getElementById('bmi-status').value = "Underweight"
    }
    else if (finalbmi > 18.5 && finalbmi < 24.9) {
        document.getElementById('bmi-status').value = "Healthy"
    }
    else if (finalbmi > 25.0 && finalbmi < 29.9) {
        document.getElementById('bmi-status').value = "Overweight"
    }
    else if (finalbmi > 29.9) {
        document.getElementById('bmi-status').value = "Obese"
    }
})
