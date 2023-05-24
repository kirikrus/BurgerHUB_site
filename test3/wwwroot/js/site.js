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
