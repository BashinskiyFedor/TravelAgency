<template>
  <div class="container-fluid mt-5">
    <div class="row">
      <custom-article v-for="(article, i) in articles" :key="i" class="col-12 mt-5" bg="card" :article="article"/>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator'
type Article = {
  id: Number,
  type: String,
  date: String,
  title: String,
  author: String,
  description: String,
  tegs: Array<String>
}

@Component({
  name: 'article'
})
export default class Articles extends Vue {
  articles: Article[] = [
    {
      id: 1,
      type: 'video',
      date: '4 november 2019',
      title: '#177: Локальная разработка Wordpress до рабочего процесса',
      author: 'Cris Coier',
      description: `Маховик является спонсором CSS-хитрости, и я рад, что они, потому что они делают отличные продукты. 
        Маховик находится в центре этого рабочего процесса.
Во-первых, Local by Flywheel - это невероятно простой способ раскрутить локальные сайты WordPress по своему вкусу. 
        Я использую его для всех моих местных разработок WordPress. Это приятный интерфейс вокруг маленьких контейнеров Docker. … Читать статью',`,
      tegs: ['css', 'js', 'vue', 'bootstrap']
    },
    {
      id: 1,
      type: 'Video',
      date: '4 november 2019',
      title: '#177: Локальная разработка Wordpress до рабочего процесса',
      author: 'Cris Coier',
      description: `Маховик является спонсором CSS-хитрости, и я рад, что они, потому что они делают отличные продукты. 
      Маховик находится в центре этого рабочего процесса.
Во-первых, Local by Flywheel - это невероятно простой способ раскрутить локальные сайты WordPress по своему вкусу. 
      Я использую его для всех моих местных разработок WordPress. Это приятный интерфейс вокруг маленьких контейнеров Docker. … Читать статью',`,
      tegs: ['css', 'js', 'vue', 'bootstrap']
    },
    {
      id: 1,
      type: 'Video',
      date: '4 november 2019',
      title: '#177: Локальная разработка Wordpress до рабочего процесса',
      author: 'Cris Coier',
      description: `Маховик является спонсором CSS-хитрости, и я рад, что они, потому что они делают отличные продукты. 
      Маховик находится в центре этого рабочего процесса.
Во-первых, Local by Flywheel - это невероятно простой способ раскрутить локальные сайты WordPress по своему вкусу. 
      Я использую его для всех моих местных разработок WordPress. Это приятный интерфейс вокруг маленьких контейнеров Docker. … Читать статью',`,
      tegs: ['css', 'js', 'vue', 'bootstrap']
    },
    {
      id: 1,
      type: 'Video',
      date: '4 november 2019',
      title: '#177: Локальная разработка Wordpress до рабочего процесса',
      author: 'Cris Coier',
      description: `Маховик является спонсором CSS-хитрости, и я рад, что они, потому что они делают отличные продукты. 
      Маховик находится в центре этого рабочего процесса.
Во-первых, Local by Flywheel - это невероятно простой способ раскрутить локальные сайты WordPress по своему вкусу. 
      Я использую его для всех моих местных разработок WordPress. Это приятный интерфейс вокруг маленьких контейнеров Docker. … Читать статью',`,
      tegs: ['css', 'js', 'vue', 'bootstrap']
    }
  ]
}
</script>
