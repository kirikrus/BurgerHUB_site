// Главная страница прокрутка бургеров-предложений
function burger_change(action) {
    var counter = document.getElementById("counter");
    var currentCount = counter.innerText.toString();
    var num = currentCount.substr(1);

    switch (action) {
        case 1:
            if (num <= 3 && num >= 1)
                num--;
            break;
        case 2:
            if (num <= 3 && num >= 1)
                num++;
            break;
    }

    var arr_l = document.getElementById("offer_arr_left");
    var arr_r = document.getElementById("offer_arr_right");

    switch (num) {
        case 0:
            arr_l.classList.add("arr_blocked");
            break;
        case 1:
            arr_l.classList.add("arr_blocked");
            break;
        case 4:
            arr_r.classList.add("arr_blocked");
            break;
        case 3:
            arr_r.classList.add("arr_blocked");
            break;
        default:
            arr_l.classList.remove("arr_blocked");
            arr_r.classList.remove("arr_blocked");
    }

    if (!(action == 1 && num == 0) && !(action == 2 && num == 4)) {

        var name = document.getElementById("offer_burger_name");
        var desc = document.getElementById("offer_burger_desc");
        var img = document.getElementById("offer_burger_img");
        var button = document.getElementById("offer_burger_bt");

        name.classList.add("fade-in");
        desc.classList.add("fade-in");
        img.classList.add("fade-in");

        setTimeout(function () {
            switch (num) {
                case 1:
                    name.innerHTML = "Black Classic: <br />вкус, который заставит вас вернуться!";
                    desc.innerHTML = "Откройте для себя наш новый черный бургер из мраморной говядины, который покорит вас своим необычным и глубоким вкусом. Мы используем только свежую мраморную говядину, что обеспечивает сочность и невероятную мягкость каждого куска мяса. А соус из свежих брусничных ягод добавляет нежную кислинку, что идеально сочетается с глубоким ароматом мраморной говядины...";
                    img.src = "img/Black_Classic.png";
                    button.onclick = function () {
                        openModal('burger_1');
                    };
                    break;
                case 2:
                    name.innerHTML = "Митон: <br />наслаждение в каждом глотке!";
                    desc.innerHTML = "Это наш уникальный бургер, созданный специально для истинных ценителей пива. Говяжья котлета, приготовленная по рецепту 'Варки', обладает интенсивным дымным ароматом, который идеально сочетается с копченым сыром сулугуни и нежным луком конфи. Каждая вкусная составляющая этого бургера привносит свою неповторимую нотку, а в сочетании с разнообразием пивных сортов в нашем баре создает настоящий гастрономический рай для вашего вкуса. Попробуйте 'Митон' и откройте для себя новый уровень удовольствия!";
                    img.src = "img/Miton.png";
                    button.onclick = function () {
                        openModal('burger_4');
                    };
                    break;
                case 3:
                    name.innerHTML = "Гурмяу: <br />восточная экзотика в каждом кусочке!";
                    desc.innerHTML = "Погрузитесь в мир восточных вкусов с нашим бургером Гурмяу. Сочный соевый стейк, приправленный специей фурикаки, станет основой этого невероятно аппетитного блюда. А соус тайской сальсы и гуакамолле добавят яркие нотки пикантности и свежести. Свежий редис, хрустящий огурец и ароматный красный лук придают бургеру текстуру и яркость, а свежая кинза добавляет свою неповторимую ароматную нотку. Гурмяу - это настоящий взрыв восточных вкусов, который пробудит все ваши чувства и оставит незабываемые впечатления!...";
                    img.src = "img/Gurmyau.png";
                    button.onclick = function () {
                        openModal('burger_2');
                    };
                    break;
            }
            counter.innerHTML = "/" + num;
            name.classList.remove("fade-in");
            desc.classList.remove("fade-in");
            img.classList.remove("fade-in");
        }, 500);
    }
}
