<template>
    <div id="navbar">
    <b-navbar toggleable="md" type="dark" variant="dark">
        <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
        <!-- Si decidimos juntar todo
         <b-navbar-brand to="/">Home</b-navbar-brand>-->
        <b-collapse is-nav id="nav_collapse">
        <b-navbar-nav>
          <b-nav-item to="/">Signos Vitales</b-nav-item>
          <b-nav-item to="/sgral">Síntoma General</b-nav-item>
          <b-nav-item to="/expgeneral">Exploración General</b-nav-item>
          <b-nav-item to="/expregional">Exploración Regional</b-nav-item>
          <b-nav-item to="/actual">Padecimiento Actual</b-nav-item>
        </b-navbar-nav>
      </b-collapse>
    </b-navbar>
    </div>
</template>

<script>
export default {
    name: 'Navbar'
}
</script>

