function pages_profile(bt_id) {
    bt_id.classList.add("white");
    switch (bt_id) {
        case "bag":
            current_order.classList.remove("white");
            history_order.classList.remove("white");
            my_burger.classList.remove("white");
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