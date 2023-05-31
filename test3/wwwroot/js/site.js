//Модальные окна
function openModal(modal_name, err = 0) {
    var modal = document.getElementById(modal_name);
    var back_ = document.getElementById("backdrop");
    modal.classList.add("open");
    back_.classList.add("open");
    document.body.classList.add("modal-open");
    if (err) {
        var err_back_ = document.getElementById("backdrop_err");
        err_back_.classList.add("open");
    }
}

function closeModal(modal_name, err = 0, double_modal_name) {
    var modal = document.getElementById(modal_name);
    var back_ = document.getElementById("backdrop");
    var err_back_ = document.getElementById("backdrop_err");
    var double_modal = document.getElementById(double_modal_name);

    modal.classList.remove("open");

    if (double_modal != null)
        double_modal.classList.remove("open");

    if (err) {
        err_back_.classList.remove("open");
    }
    else {
        back_.classList.remove("open");
        document.body.classList.remove("modal-open");
    }

}
// Анимации и стили
function menu_filter_button_color(bt_name) {

    switch (bt_name) {
        case "bt_all":
            bt_all.classList.add("white");
            bt_eco.classList.remove("white");
            bt_hit.classList.remove("white");
            break;
        case "bt_eco":
            bt_all.classList.remove("white");
            bt_eco.classList.add("white");
            bt_hit.classList.remove("white");
            break;
        case "bt_hit":
            bt_all.classList.remove("white");
            bt_eco.classList.remove("white");
            bt_hit.classList.add("white");
            break;
    }
}