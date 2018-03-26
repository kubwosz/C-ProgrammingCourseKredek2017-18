
const API_LINK = 'http://localhost:56736/api';


//Funkcja wypełaniająca(odświeżająca listę po lewej stronie)
function renderMenuLeft(items) {
    var ul = document.querySelector('#left-menu ul');

    for (var i = 0; i < items.length; i++) {
        // Przygotowanie <li>
        var li = document.createElement('li');
        li.id = items[i].ID;
        li.className = 'list-group-item';
        li.textContent = items[i].ClientName;

        // Gdy element listy zostanie kliknięty
        li.onclick = function () {
            var liPreviousActive = document.getElementsByClassName('active');
            if (liPreviousActive.length > 0) {
                liPreviousActive[0].className = 'list-group-item';
            }
            this.className = 'list-group-item active';
            var hardwareIndex = document.getElementById(this.id);
            var foundHardware = items.find(function (hardware) {
                return hardware.ID == hardwareIndex.id;
            });
            renderDetail(foundHardware);
        };

        // Element wypełnia html
        ul.appendChild(li);
    }

}

function renderDetail(item) {
    document.querySelector('.card-title').textContent = item.ClientName;
    var ul = document.querySelector('#detail ul');
    var ulTextContent = '';
    // Dla kazdego elementu zostaje tworzony kolejny li
    for (var key in item) {
        ulTextContent += '<li>' + key + ': ' + item[key] + '</li>';
    }
    //Zamiana starych wartości nowymi
    ul.innerHTML = ulTextContent;
}

//Funckja szukająca klienta po imieniu
function searching(items) {
    $('#search_btn').click(function (event) {
        var clientName = document.getElementById("search_text").value;

        var previousActiveSearch = document.getElementsByClassName('active');

        if (previousActiveSearch.length > 0) {
            previousActiveSearch.className = 'list-group-item';
        }
            


    for (var i = 0; i < items.length; i++) {
        if (items[i].ClientName == clientName) {
            renderDetail(items[i]);
            var li = document.getElementById(items[i].ID);
            li.className = 'list-group-item active';
        }
    }
    })
}

//Funkcja zarządzająca paskiem progresywnym
function progressBar() {
    var point1 = 0, point2 = 0, point3 = 0;
    var bar = document.getElementsByClassName("progress-bar");

    if ($('input[name = "orderNumber"]').val() != "") {
        point1 = 34;
    }
    if ($('input[name = "clientName"]').val() != "") {
        point2 = 33;
    }
    if ($('input[name = "clientSurname"]').val() != "") {
        point3 = 33;
    }

    var value = point1 + point2 + point3;

    $('.progress-bar').css('width', value + '%').attr('aria-valuenow', value);
}


$(document).ready(function () {
    console.log('Hello! Your document is ready');

    $('.dropdown-item').click(function (event) {
        $('input[name="city"]').val(event.target.textContent);
    })

    $('.form-control').click(function (event) {
        progressBar();
    })
    // Odpowiedź serewera na zapyanie GEt w json  
    var request = $.ajax({
        url: API_LINK + '/orders',
        method: "GET",
        dataType: "json"
    });

    //Gdy serwer odpowie
    request.done(function (response) {
        console.log('response');
        orders = response;

        searching(orders);
        renderMenuLeft(orders);
        renderDetail(orders[0]);
        

        //Spinner zostanie usunięty gdy zostanie nawiązane połącznie
        $('.loading').removeClass('loader');

    });

    //Zapisywannie, dodaanie nowego zamówienia
    $('#saveButton').click(function () {

        var newOrder = {
            NumberOfOrder: $('input[name = "orderNumber"]').val(),
            ClientName: $('input[name = "clientName"]').val(),
            ClientSurname: $('input[name = "clientSurname"]').val()
        };
        console.log('saving');

        var requestPOST = $.ajax({
            url: API_LINK + '/orders',
            method: "POST",
            dataType: "json",
            data: newOrder
        });

        requestPOST.done(function (response) {
            orders.push(response);
            renderMenuLeft(orders);
        });
    });

});
