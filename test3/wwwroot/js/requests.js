
function user_profile() {
    if (sessionStorage.getItem("isLoggedIn") == "true") {
        var decrypted = atob(atob(sessionStorage.getItem("user")));
        window.location.href = 'Profile?ID=' + decrypted;
    } else
        openModal('login_window');
}

function submitForm(event) { //ОБРАБОТКА ВХОДА
    event.preventDefault(); // Предотвращаем обычное поведение формы (перезагрузку страницы)

    // Получаем данные из формы
    var form = document.getElementById("login_window");

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
        .then(function (data) {//это json который вернул бэк
            if (data.success) {//обработка если есть такой пользователь
                sessionStorage.setItem("isLoggedIn", "true");
                sessionStorage.setItem("user", btoa(btoa(data.client)));

                window.location.href = 'Profile?ID=' + data.client;
            } else {
                var input = document.getElementsByClassName("attention_non");

                for (var i = 0; i < input.length; i++)
                    input[i].classList.add("attention");

                setTimeout(function () {
                for (var i = 0; i < input.length; i++)
                    input[i].classList.remove("attention");
                }, 500);

                sessionStorage.setItem("isLoggedIn", "false");
            }
        })
        .catch(function (error) {
            // ВЫвод ошибок в логе
            console.error(error);
        });
}

function add_to_bag(burger_id) {//добавление в корзину
    if (sessionStorage.getItem("isLoggedIn") == "true") {
        var User = atob(atob(sessionStorage.getItem("user")));
        var jsonData = {
            BurgerID: burger_id,
            User_id: User
        };

        fetch("https://localhost:7026/ShopBasket/GetPositionOrder", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(jsonData)
        })
    }
}

function submitForm_reg(event) {//обработка регистрации
    event.preventDefault(); 
    var form = document.getElementById("reg_window");

    var jsonData = {
        Surname: form[1].value,
        Name: form[2].value,
        Patronymic: form[3].value,
        Email: form[4].value,
        Tel: form[5].value,
        Adres: form[6].value
    };

    fetch("https://localhost:7026/Clients/ProcessLoginForm", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(jsonData)
    })
        .then(function (response) {
            if (response.ok) {
                return response.json();
            } else {
                throw new Error("Ошибка при обработке данных");
            }
        })
        .then(function (data) {
            if (data.success) {
                sessionStorage.setItem("isLoggedIn", "true");
                sessionStorage.setItem("user", btoa(btoa(data.client)));

                window.location.href = 'Profile?ID=' + data.client;
            } else {
                var input = document.getElementsByClassName("attention_non");

                for (var i = 0; i < input.length; i++)
                    input[i].classList.add("attention");

                setTimeout(function () {
                    for (var i = 0; i < input.length; i++)
                        input[i].classList.remove("attention");
                }, 500);

                sessionStorage.setItem("isLoggedIn", "false");
            }
        })
        .catch(function (error) {
            console.error(error);
        });
}

function delete_from_bag(position_id){ //удаление из корзины
        var jsonData = {
            Position_Id: position_id,
            User_id: User
        };

        fetch("", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(jsonData)
        })
}

function submitForm_setting(event) { // Настройки
    event.preventDefault();
    var form = document.getElementById("setting_window");

    var jsonData = {
        Surname: form[1].value,
        Name: form[2].value,
        Patronymic: form[3].value,
        Email: form[4].value,
        Tel: form[5].value,
        Adres: form[6].value
    };

    fetch("", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(jsonData)
    })
}