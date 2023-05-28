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

    // Преобразуем данные в JSON
    var jsonData = {};
    formData.forEach(function (value, key) {
        jsonData[key] = value;
    });

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
            // Обработка данных из успешного ответа
            console.log(data);
        })
        .catch(function (error) {
            // Обработка ошибок
            console.error(error);
        });
}

// Анимации и стили
function menu_filter_button_color(bt_name) {
    var BT_all = document.getElementById("bt_all");
    var BT_eco = document.getElementById("bt_eco");
    var BT_hit = document.getElementById("bt_hit");

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