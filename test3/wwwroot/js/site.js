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

function closeModal(modal_name, err = 0) {
    var modal = document.getElementById(modal_name);
    var back_ = document.getElementById("backdrop");
    var err_back_ = document.getElementById("backdrop_err");

    modal.classList.remove("open");

    if (err) {
        err_back_.classList.remove("open");
    }
    else {
        back_.classList.remove("open");
        document.body.classList.remove("modal-open");
    }

}

function submitForm(event) {
    event.preventDefault(); // Предотвращаем обычное поведение формы (перезагрузку страницы)

    // Получаем данные из формы
    var form = document.getElementById("login_window");
    var formData = new FormData(form);

    // Отправляем данные на бэкэнд AJAX
    fetch("url_обработчика", {
        method: "POST",
        body: formData
    })
        .then(function (response) {
            // Обработка ответа от бэка
            if (response.ok) {
                // Действия при успешной обработке данных
            } else {
                // Действия при ошибке обработки данных
            }
        })
        .catch(function (error) {
            // Обработка ошибок
        });
}
