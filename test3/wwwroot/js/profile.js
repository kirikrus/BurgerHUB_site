function pages_profile(bt_id) {
    var bt_name = document.getElementById(bt_id);
    bt_name.classList.add("white");

    switch (bt_id) {
        case "bag":
            history_order.classList.remove("white");
            my_burger.classList.remove("white");

            history_order_page.classList.remove("open_grid");
            my_burger_page.classList.remove("open_grid");
            bag_page.classList.add("open_grid");

            break;
        case "history_order":
            bag.classList.remove("white");
            my_burger.classList.remove("white");

            my_burger_page.classList.remove("open_grid");
            bag_page.classList.remove("open_grid");
            history_order_page.classList.add("open_grid");

            break;
        case "my_burger":
            history_order.classList.remove("white");
            bag.classList.remove("white");

            bag_page.classList.remove("open_grid");
            history_order_page.classList.remove("open_grid");
            my_burger_page.classList.remove("open_grid");

            break;
    }
}