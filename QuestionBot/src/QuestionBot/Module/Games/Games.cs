[NadekoCommand, Usage, Description, Aliases]
        public async Task _8Ball([Remainder] string question = null)
        {
            if (string.IsNullOrWhiteSpace(question))
                return;

            await Context.Channel.EmbedAsync(new EmbedBuilder().WithColor(NadekoBot.OkColor)
                               .AddField(efb => efb.WithName("❓ " + GetText("question") ).WithValue(question).WithIsInline(false))
                               .AddField(efb => efb.WithName("🎱 " + GetText("8ball")).WithValue(_service.EightBallResponses[new NadekoRandom().Next(0, _service.EightBallResponses.Length)]).WithIsInline(false)));
        }
