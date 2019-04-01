<template>
    <div class="search">
        <input type="text" @keyup="filterTodos" id="search" name="search" placeholder="Search Todo's..." />
    </div>
</template>

<script>
export default {
    
    methods: {
        filterTodos() {
            const query = document.getElementById('search').value;
            this.$emit('filter-todos', query);
        }
    }
}
</script>

<style>
#search {
    width:100%;
    font-size:24px;
    font-family: 'Roboto Condensed', sans-serif;
    padding:10px;
}
</style>
