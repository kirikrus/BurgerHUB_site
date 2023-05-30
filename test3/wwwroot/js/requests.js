﻿function submitForm(event) { //ОБРАБОТКА ВХОДА
    event.preventDefault(); // Предотвращаем обычное поведение формы (перезагрузку страницы)

    // Получаем данные из формы
    var form = document.getElementById("login_window");
    var formData = new FormData(form);

    // Преобразуем данные в JSON
    var jsonData = {
        Email: form[1].value,
        Password: form[2].value
    };


    // Отправляем данные на бэкэнд AJAX
    fetch("https://localhost:7026/Clients/ProcessLoginForm", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(jsonData)
    })
        .then(function (response) {
            if (response.ok) {
                // Действия при успешной обработке данных
                return response.json(); // Преобразуем ответ в JSON
            } else {
                // Действия при ошибке обработки данных
                throw new Error("Ошибка при обработке данных");
            }
        })
        .then(function (data) {
            // Вывод данных из успешного ответа в логе
            console.log(data);
        })
        .catch(function (error) {
            // ВЫвод ошибок в логе
            console.error(error);
        });
}