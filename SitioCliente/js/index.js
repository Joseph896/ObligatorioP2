

function AgregarReserva() {
    var nombre =    $("#nombre").val();
    var apellido =  $("#apellido").val();
    var documento = $("#doc").val();
    var telefono =  $("#tel").val();
    var cantidad =  $("#cantidad").val();
    var mesa =      $("#mesa").val();
    var fecha =     $("#fecha").val();

    var reserva = {
        nombre: nombre,
        apellido: apellido,
        documento: documento,
        telefono: telefono,
        cantidadComensales: cantidad,
        mesa: mesa,
        fechaHoraDeReserva: fecha
    };

    $.ajax({
        type: "POST", // Tipo de petición (POST, PUT, GET o DELETE)
        data: JSON.stringify(reserva), // parseo de objeto a string 
        contentType: "application/json", //Lenguaje de comunicación entre el Cliente y el Servidor (Ws)
        url: "http://localhost:44375/api/Reserva/AgregarReserva",
        success: function (respuesta) {

            if (respuesta.length > 0) {

                for (var i = 0; i < respuesta.length; i++) {
                    alert(respuesta[i]);
                }
            }
            else {
                alert("La reserva fue registrada correctamente");
                ListarReservas();
                $("#reservas")[0].reset();
            }


        },
        error: function (respuesta) {
            //404 o 500
        }
    })
}

function ListarReservas() {
    $.ajax({
        type: "GET", // Tipo de petición (POST, PUT, GET o DELETE)
        contentType: "application/json", //Lenguaje de comunicación entre el Cliente y el Servidor (Ws)
        url: "http://localhost:44375/api/Reserva/ListarReservas",
        success: function (respuesta) {

            document.getElementById("tblReservas").innerHTML = "";
            
            if (respuesta.length > 0) {

                for (var i = 0; i < respuesta.length; i++) {

                    var columNumero = "<td>" + respuesta[i].numero + "</td>";
                    var columCliente = "<td>" + respuesta[i].nombre + " " + respuesta[i].apellido + "</td>";
                    var columMesa = "<td>" + respuesta[i].mesa + "</td>";
                    var columFecha = "<td>" + respuesta[i].fechaHoraDeReserva + "</td>";
                    var columCantidad = "<td>" + respuesta[i].cantidadComensales + "</td>";
                    

                    //Usamos la '\' para que el caracter siguiente a la misma lo tome de fomra literal
                    

                    document.getElementById("tblReservas").innerHTML += "<tr>" + columNumero + columCliente + columMesa + columFecha + columCantidad + "</tr>";
                }

            }

        },
        error: function (respuesta) {
            //404 o 500
        }
    })
}



function RegistrarCliente() {
    var nombre = $("#nombreC").val();
    var apellido = $("#apellidoC").val();
    var documento = $("#docC").val();
    var telefono = $("#telC").val();


    var cliente = {
        nombre: nombre,
        apellido: apellido,
        documento: documento,
        telefono: telefono
    };

    $.ajax({
        type: "POST", // Tipo de petición (POST, PUT, GET o DELETE)
        data: JSON.stringify(cliente), // parseo de objeto a string 
        contentType: "application/json", //Lenguaje de comunicación entre el Cliente y el Servidor (Ws)
        url: "http://localhost:44375/api/Cliente/RegistrarCliente",
        success: function (respuesta) {

            if (respuesta.length > 0) {

                for (var i = 0; i < respuesta.length; i++) {
                    alert(respuesta[i]);
                }
            }
            else {
                alert("El cliente fue registrado correctamente");
               
                
            }


        },
        error: function (respuesta) {
            //404 o 500
        }
    })
}

function BuscarCliente() {

    var documento = $("#buscar").val();

    $.ajax({
        type: "GET", // Tipo de petición (POST, PUT, GET o DELETE)
        contentType: "application/json", //Lenguaje de comunicación entre el Cliente y el Servidor (Ws)
        url: "http://localhost:44375/api/Cliente/BuscarCliente?documento=" + documento,
        success: function (respuesta) {

            if (respuesta.nombre != null) {
                alert("Cliente " + respuesta.nombre + " encontrado");
            }
            else {
                alert("Cliente no registrado");
            }
        },
        error: function (respuesta) {
            //404 o 500
            
        }
    })
}

