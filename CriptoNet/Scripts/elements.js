

function mandarprecio(precio) {
    reset();
    var PrecioCombo = document.getElementById('precio');
    var PrecioVenta = document.getElementById('preciov');
    PrecioCombo.value = precio;
    PrecioVenta.value = precio;

}

function total() {

    var total=document.getElementById('Total');
    var MontoComprar=document.getElementById('monto');
    var PrecioCombo= document.getElementById('precio');
    var Multi = (parseFloat(MontoComprar.value) / parseFloat(PrecioCombo.value));
    if(PrecioCombo.value==="12"){
        total.innerText = "Total: " + Multi + " BTC";
        CambiarInfo(Multi, MontoComprar.value, "BTC");
    }
    if(PrecioCombo.value==="13"){
        total.innerText = "Total: " + Multi + " ETH";
        CambiarInfo(Multi, MontoComprar.value, "ETH");
    }
    if(PrecioCombo.value==="14"){
        total.innerText = "Total: " + Multi + " XRP";
        CambiarInfo(Multi, MontoComprar.value, "XRP");
    }
    if(PrecioCombo.value==="15"){
        total.innerText = "Total: " + Multi + " LTC";
        CambiarInfo(Multi, MontoComprar.value, "LTC");
    }
    if(PrecioCombo.value==="16"){
        total.innerText = "Total: " + Multi + " BCH";
        CambiarInfo(Multi, MontoComprar.value, "BCH");
    }
    if(PrecioCombo.value==="17"){
        total.innerText = "Total: " + Multi + " TUSD";
        CambiarInfo(Multi, MontoComprar.value, "TUSD");
    }
    if(PrecioCombo.value==="18"){
        total.innerText = "Total: " + Multi + " BAT";
        CambiarInfo(Multi, MontoComprar.value, "BAT");
    }
    if(PrecioCombo.value==="19"){
        total.innerText = "Total: " + Multi + " GNT";
        CambiarInfo(Multi, MontoComprar.value, "GNT");
    }
    if(PrecioCombo.value==="20"){
        total.innerText = "Total: " + Multi + " MANA";
        CambiarInfo(Multi, MontoComprar.value, "MANA");
    }

}

function reset(){
    var MontoComprar = document.getElementById('monto');
    var MontoVender = document.getElementById('montov');
    var PrecioCombo = document.getElementById('precio');
    var PrecioVenta = document.getElementById('preciov');
    var total = document.getElementById('Total');
    var totalvender = document.getElementById('tv');

    total.innerText = "Total: ";
    totalvender.innerText = "Total: ";
    MontoVender.value = "";
    PrecioVenta.value = "";
    PrecioCombo.value = "";
    MontoComprar.value = ""; 
}  

function venta() {
    var total = document.getElementById('tv');
    var MontoVender = document.getElementById('montov');
    var PrecioCombo = document.getElementById('preciov');
    var Multi = (parseFloat(MontoVender.value) * parseFloat(PrecioCombo.value));

    if (PrecioCombo.value === "12") {
        total.innerText = "Total: $" + Multi ;
        CambiarInfoV(Multi, MontoVender.value, "BTC");
    }
    if (PrecioCombo.value === "13") {
        total.innerText = "Total: $" + Multi;
        CambiarInfoV(Multi, MontoVender.value, "ETH");
    }
    if (PrecioCombo.value === "14") {
        total.innerText = "Total: $" + Multi;
        CambiarInfoV(Multi, MontoVender.value, "XRP");
    }
    if (PrecioCombo.value === "15") {
        total.innerText = "Total: $" + Multi;
        CambiarInfoV(Multi, MontoVender.value, "LTC");
    }
    if (PrecioCombo.value === "16") {
        total.innerText = "Total: $" + Multi;
        CambiarInfoV(Multi, MontoVender.value, "BCH");
    }
    if (PrecioCombo.value === "17") {
        total.innerText = "Total: $" + Multi;
        CambiarInfoV(Multi, MontoVender.value, "TUSD");
    }
    if (PrecioCombo.value === "18") {
        total.innerText = "Total: $" + Multi;
        CambiarInfoV(Multi, MontoVender.value, "BAT");
    }
    if (PrecioCombo.value === "19") {
        total.innerText = "Total: $" + Multi;
        CambiarInfoV(Multi, MontoVender.value, "GNT");
    }
    if (PrecioCombo.value === "20") {
        total.innerText = "Total: $" + Multi;
        CambiarInfoV(Multi, MontoVender.value, "MANA");
    }


}

function CambiarInfo(Multi, Monto, Nombre) {
    var Descripcion = document.getElementById('Descp');
    Descripcion.value = 'Realizaste una compra de '+Multi+' '+Nombre+' por un total de $'+Monto;
}

function CambiarInfoV(Multi, Monto, Nombre) {
    var DescripcionVenta = document.getElementById('DescpV');
    DescripcionVenta.value = 'Realizaste una venta de ' + Monto + ' ' + Nombre + ' con la ganancia de $' + Multi;
}


