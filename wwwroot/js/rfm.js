////let btn_1 = decument.getElementById('btn_rfm');

////btn_1.addEventListener('click', function () {
////    let height_1 = document.getElementById('height-input-rfm').value;
////    let waist_1 = document.getElementById('waist-input-rfm').value;
////    let finalrfm_1 = 76 - (20 * height_1 / waist_1)
////    document.getElementById('rfm-output').value = finalrfm_1
////})

let btn = document.getElementById('btn_rfm');

btn.addEventListener('click', function () {
    let height_rfm = document.getElementById('height-input-rfm').value;
    let waist_rfm = document.getElementById('waist-input-rfm').value;
    let finalrfm = 64 - (20 * height_rfm / waist_rfm)
    document.getElementById('rfm-output').value = finalrfm;
})