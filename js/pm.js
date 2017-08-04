$(document).ready(function() {

    $("input[type=checkbox]").click(function() {
        var control = this;
        var tareaID = this.value;

        $.ajax({
            url: "/pm/tareas/completarTarea.aspx?id=" + tareaID
        }).done(function(data) {
            if (data == "Listo") {
                $(control).parent().parent().hide();
            } else {
                alert("no se pudo completar la tarea");
            }
        });

    });
});