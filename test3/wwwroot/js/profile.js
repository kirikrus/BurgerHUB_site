function pages_profile(bt_id) {
    var bt_name = document.getElementById(bt_id);
    bt_name.classList.add("white");

    var pagesSide = document.querySelector('.pages_side');
    pagesSide.innerHTML = '';

    switch (bt_id) {
        case "bag":
            current_order.classList.remove("white");
            history_order.classList.remove("white");
            my_burger.classList.remove("white");

            var componentHtml = '<h2>Корзина</h2>' +
                '<p>Содержимое вашей корзины здесь...</p>';
            pagesSide.innerHTML = componentHtml;

            break;
        case "current_order":
            bag.classList.remove("white");
            history_order.classList.remove("white");
            my_burger.classList.remove("white");
            break;
        case "history_order":
            current_order.classList.remove("white");
            bag.classList.remove("white");
            my_burger.classList.remove("white");
            break;
        case "my_burger":
            current_order.classList.remove("white");
            history_order.classList.remove("white");
            bag.classList.remove("white");
            break;
    }
}