<template>
  <div class="pl-5 pr-5">
    <article class="card entry" :class="[`bg-${bg}`]">
      <section>
        <div class="entry-left">
          <img class="card entry-left__img" src="https://picsum.photos/1000/1000" alt="Card image cap">
          <div class="card-img-overlay align-content-end">
            <time class="entry-right__datetime card-text text-muted mt-3+-">{{article.date}}</time>
            <h3 class="entry-right__title card-title text-white">{{article.title}}</h3>
          </div>
        </div>
        <div class="entry-right">
          <div class="card-body">
            <p class="article-right__description card-text text-muted">{{article.description}}</p>
          </div>
        </div>
      </section>
      <section class="entry-footer">
        <div class="col-12">
          <div class="entry-footer__author">
            <img class="rounded-circle" src="https://picsum.photos/1000/1000">
            <div class="author__name">
              <span class="text-muted">Author</span>
              <a href="/BrainRenaldi">Brein Renaldi</a>
            </div>
          </div>
        </div>
        <div class="col-12">
          <ul class="entry-footer__statistics">
            <li class="statistics__item">
              <a class="statistics__link" href="#"><icon :icon="['fas','eye']" /><span>1238</span></a>
            </li>
            <li class="statistics__item">
              <a class="statistics__link" href="#"><icon :icon="['fas','eye']" /><span>12</span></a>
            </li>
            <li class="statistics__item">
              <a class="statistics__link" href="#"><icon :icon="['fas','eye']" /><span>123</span></a>
            </li>
          </ul>
        </div>
      </section>
    </article>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator'
@Component({ name: 'custom-article' })
export default class CustomArticle extends Vue {
  @Prop() article!: Object
  @Prop() bg!: String
}
</script>
