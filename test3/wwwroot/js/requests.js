
function user_profile() {
    if (sessionStorage.getItem("isLoggedIn") == "true")
        window.location.href = 'Profile?ID=' + clientID;
    else
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
                sessionStorage.setItem("isLoggedIn", "true");
                return response.json(); // Преобразуем ответ в JSON
            } else {
                // Действия при ошибке обработки данных
                sessionStorage.setItem("isLoggedIn", "false");
                throw new Error("Ошибка при обработке данных");
            }
        })
        .then(function (data) {

            var clientID = data.client;
            // Выполняем перенаправление на страницу Profile с передачей ClientID
            window.location.href = 'Profile?ID=' + clientID;
        })
        .catch(function (error) {
            // ВЫвод ошибок в логе
            console.error(error);
        });
}

function add_to_bag(burger_id) {
    //var jsonData = {
    //    BurgerID: burger_id,
    //};

    //fetch("https://localhost:7026/Clients/ProcessLoginForm", {
    //    method: "POST",
    //    headers: {
    //        "Content-Type": "application/json"
    //    },
    //    body: JSON.stringify(jsonData)
    //})
    //    .then(function (response) {
    //        if (response.ok) {

    //        }
    //    })
}
