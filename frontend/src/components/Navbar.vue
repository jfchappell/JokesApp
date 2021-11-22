<template>
    <nav class="navbar navbar-light navbar-expand bg-light navigation-clean">
        <div class="container-fluid">
            <a class="navbar-brand" href="/">Jokes App</a>
            <ul class="navbar-nav me-auto">
                <li class="nav-item">
                    <a class="nav-link" href="/">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/add">Add Joke</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/edit">Edit Joke</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/delete">Delete Joke</a>
                </li>
            </ul>
        </div>
    </nav>
</template>

<style lang="less" scoped>
.navbar {
  width: 100%;
  align-items: center;
  background: grey;
  text-align: left;
  padding: 5px;
  padding-bottom: 5px;
  background: #6c5b7b !important;

  .navbar-brand {
    font-weight: bold;
    color: white;
    &:hover{
        color: #ffc0cb;
    }
}

    .nav-item {
        .nav-link{
            display: flex;
            align-items: center;
            font-weight: normal;
            color: white;
            &:hover{
                color: #ffc0cb;
                font-weight: bold;
            }
        }
    }
}
</style>