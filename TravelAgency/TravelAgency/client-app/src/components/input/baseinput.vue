<template>
  <div class="form-group input-group"
       :class="[
       {'has-danger': error},
       {'focused': focused},
       {'has-label': label || $slots.label},
       {'has-success': valid === true},
       {'has-danger': valid === false}
       ]">
    <slot v-bind="slotData">
      <input :value="value"
             v-bind="$attrs"
             v-on="listeners"
             class="form-control"
             :class="[
                {'is-valid': valid === true},
                {'is-invalid': valid === false}, inputClasses]"
             aria-describedby="addon-right addon-left">
    </slot>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator'
@Component({
  name: 'base-input'
})
export default class BaseInput extends Vue {
  @Prop() required!: Boolean
  @Prop({ default: undefined }) valid!: Boolean
  @Prop() label!: String
  @Prop() error!: String
  @Prop() labelClasses!: String
  @Prop() inputClasses!: String
  @Prop([String, Number]) value!: string | number | undefined
  @Prop() addonRightIcon!: String
  @Prop() addonLeftIcon!: String

  focused = false

  get listeners () {
    return {
      ...this.$listeners,
      input: this.updateValue,
      focus: this.onFocus,
      blur: this.onBlur
    }
  }

  get slotData () {
    return {
      focused: this.focused,
      ...this.listeners
    }
  }

  updateValue (evt: any) {
    let value = evt.target.value
    this.$emit('focus', value)
  }

  onFocus (value: any) {
    this.focused = true
    this.$emit('focus', value)
  }

  onBlur (value: any) {
    this.focused = false
    this.$emit('blur', value)
  }
}
</script>
