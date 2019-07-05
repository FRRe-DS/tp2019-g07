<template>
    <b-container id="encabezado">
        <h1 class="text-center">{{ titulo }}</h1>       
    </b-container>
</template>

<script>
export default {
    name: 'Encabezado',
    props: ['titulo']
}
</script>
