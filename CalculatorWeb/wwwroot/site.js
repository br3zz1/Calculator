
window.addEventListener("load", initializeCalculatorButtons);

function initializeCalculatorButtons() {
    const buttons = Array.from(document.getElementsByClassName("calc-button"));
    buttons.forEach(button => button.addEventListener("click", onCalculatorButtonClick));

    const clearButtons = Array.from(document.getElementsByClassName("calc-clear-button"));
    clearButtons.forEach(button => button.addEventListener("click", onCalculatorClearButtonClick));
}

function onCalculatorButtonClick() {
    const mainInput = document.getElementById("mainInput");
    mainInput.value = mainInput.value + this.value;
}

function onCalculatorClearButtonClick() {
    const mainInput = document.getElementById("mainInput");
    mainInput.value = "";
}
