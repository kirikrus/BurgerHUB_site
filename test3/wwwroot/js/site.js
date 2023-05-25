function openModal() {
    var modal = document.getElementById("login_window");
    var back_ = document.getElementById("backdrop");
    modal.classList.add("open");
    back_.classList.add("open");
    document.body.classList.add("modal-open");
}

function closeModal() {
    var modal = document.getElementById("login_window");
    var back_ = document.getElementById("backdrop");
    modal.classList.remove("open");
    back_.classList.remove("open");
    document.body.classList.remove("modal-open");
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
