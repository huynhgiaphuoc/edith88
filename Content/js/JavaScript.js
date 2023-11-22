<script type="text/javascript">
    let box = document.querySelector('.box');
    window.omousemove = function (e) {
        let x = e.clientX / 3;
    box.style.transform = "perspective(1000px) rolateY(" + x + "deg)";
    }

</script>