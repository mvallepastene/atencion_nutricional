
function validarFormVacio(formulario){
		datos=$('#' + formulario).serialize();
		d=datos.split('&');
		vacios=0;
		for(i=0;i< d.length;i++){
				controles=d[i].split("=");
				if(controles[1]=="A" || controles[1]==""){
					vacios++;
				}
		}
		return vacios;
}


//Funcion que limpria los controles fel formulario para crear al usuario
function cleanControls() {
    $('#rut').val("");
    $('#dv').val("");
    $("#nombre").val("");
    $('#apellido').val("");
    $('#email').val("");
    $('#usuario').val("");
    $('#conf_contrasena').val("");
    $('#contrasena').val("");
    $('#tipo_user').val("A");
    $('#agencia').val("A");
    $('#siActivo').prop('checked', false);
}